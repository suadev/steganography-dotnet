using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Steganography
{
    public class Importer
    {
        private MainForm _form;
        private Helper _helper;

        public Importer(MainForm form)
        {
            _form = form;
            _helper = new Helper(_form);
        }

        /// <summary>
        /// Checks selected file before starting the process
        /// </summary>
        /// <returns></returns>
        private bool CheckBeforeImport()
        {
            if (_form.ImageHeight == 0)
            {
                
                MessageBox.Show("Open an image file!", CommonConstants.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (((_form.ImageWidth * (_form.ImageHeight - 1) * 3) / 7) < _form.ImportTextBoxText.Length)
            {
                MessageBox.Show("Too much text for the selected image!", CommonConstants.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Sets selected file info on the form.
        /// </summary>
        public void SetImportedImageInfo()
        {
            _form.ImageWidth = _form.ImportPictureBoxImage.Width;
            _form.ImageHeight = _form.ImportPictureBoxImage.Height;
            _form.ImportWidthLabelText = _form.ImageWidth.ToString();
            _form.ImportHeightLabelText = _form.ImageHeight.ToString();
            _form.ImportFormatLabelText = _form.ImportPictureBoxImage.PixelFormat.ToString();
            _form.ImportPixelsLabelText = (_form.ImageWidth * _form.ImageHeight).ToString();
            _form.ImportMaxLengthLabelText = ((_form.ImageWidth * (_form.ImageHeight - 1) * 3) / 7) + "  characters.";
        }

        /// <summary>
        /// Imports the text length using the bottom pixels line of the selected image file.
        /// </summary>
        private void ImportTextLength()
        {
            var thirtyBytes = string.Empty;
            int counter = 0, y = 0;
            var newBottom = string.Empty;
            var textLength = _form.ImportTextBoxText.Length.ToString().PadLeft(5, '0');
            var textLengthDecimalArray = textLength.ToCharArray(); // 0 -> 0
            var textLengthBinary = textLengthDecimalArray.Aggregate(string.Empty, (current, t) => current + Convert.ToString(t, 2)); // 0 -> 110000

            for (var i = 0; i < 10; i++)
                thirtyBytes += Convert.ToString(_form.Bmp.GetPixel(i, _form.ImageHeight - 1).ToArgb(), 2).Substring(8);

            while (30 > counter) // (max. 99999 chars means max 30 bytes)
            {
                newBottom = newBottom + thirtyBytes.Substring(y, 7) + int.Parse(textLengthBinary.Substring(counter, 1));
                counter++;
                y += 8;
            }

            y = 0;
            var arrayToImport = _helper.StringToByteArray(newBottom);
            for (var i = 0; i < 10; i++)
            {
                _form.Bmp.SetPixel(i, _form.ImageHeight - 1, Color.FromArgb(arrayToImport[y], arrayToImport[y + 1], arrayToImport[y + 2]));
                y += 3;
            }
        }

        /// <summary>
        /// Imports the text into the selected image file by starting from top left corner.
        /// </summary>
        public void Import()
        {
            _form.Sw = new Stopwatch();
            _form.Sw.Start();
            _form.ImportProgressBarValue = 0;

            if (CheckBeforeImport())
            {
                string bitsToImport = string.Empty;
                var charsToImport = _form.ImportTextBoxText.ToCharArray();
                var totalBytes = charsToImport.Length * 7;
                var totalPixels = totalBytes / 3; // Total number of pixels to be used.
                var totalBytesMod3 = totalBytes % 3;
                if (totalBytesMod3 != 0)
                    totalPixels++;
                _form.ImportProgressBarMaximum = totalPixels + totalBytes;

                foreach (var chr in charsToImport)// bitsToImport holds the bit form of the character that will be imported.
                {
                    var charToBits = Convert.ToString(chr, 2);
                    if (charToBits.Length > 7)
                    {
                        bitsToImport += _helper.TurkishCharTo7Bit(chr);
                    }
                    else
                    {
                        bitsToImport += charToBits.PadLeft(7, '0'); // All characters must be defined by seven bits.
                    }
                }

                var imageBits = _helper.GetOnlyNecessaryBytesFromImage(totalPixels, totalBytesMod3, _form.ImpProgressBar);
                int sevenBitPointer = 0, oneBitPointer = 0;
                var imageBitsLast = string.Empty;

                while (bitsToImport.Length > oneBitPointer) //bitsToImport is importing into imagebits. the result is stored in imageBitLast.
                {
                    imageBitsLast += imageBits.Substring(sevenBitPointer, 7) + int.Parse(bitsToImport.Substring(oneBitPointer, 1));
                    oneBitPointer++;
                    sevenBitPointer += 8;
                    _form.ImpProgressBar.Increment(1);
                }

                ImportTextLength();
                imageBitsLast += imageBits.Substring(sevenBitPointer);
                _form.ImportPictureBoxImage = _form.Bmp = _helper.ByteArrayToBitmap(_helper.StringToByteArray(imageBitsLast));
                SetInfoLabels();
            }
        }

        /// <summary>
        /// Set process result info on the screen.
        /// </summary>
        private void SetInfoLabels()
        {
            _form.Sw.Stop();
            _form.ImportedTextLengtLabelText = _form.ImportTextBoxText.Length.ToString();
            _form.ImportDurationLabelText = string.Format("{0} mins. {1} secs. {2} msec.", _form.Sw.Elapsed.Minutes, _form.Sw.Elapsed.Seconds, +_form.Sw.Elapsed.Milliseconds);
            _form.ImportTickPictureBoxVisible = true;
        }
    }
}