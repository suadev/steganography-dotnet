using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Steganography
{
    public class Exporter
    {
        private MainForm _form;
        private Helper _helper;
        public Exporter(MainForm form)
        {
            _form = form;
            _helper = new Helper(form);
        }

        /// <summary>
        /// Checks selected file before starting the process.
        /// </summary>
        /// <returns></returns>
        private int CheckBeforeExport()
        {
            try
            {
                return ExportTextLength();
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Sets selected file info on the form.
        /// </summary>
        public void SetExportedImageInfo()
        {
            _form.ImageWidth = _form.ExportPictureBoxImage.Width;
            _form.ImageHeight = _form.ExportPictureBoxImage.Height;
            _form.ExportWidthLabelText = _form.ImageWidth.ToString();
            _form.ExportHeightLabelText = _form.ImageHeight.ToString();
            _form.ExportFormatLabelText = _form.ExportPictureBoxImage.PixelFormat.ToString();
            _form.ExportPixelsLabelText = (_form.ImageWidth * _form.ImageHeight).ToString();
            _form.ExportMaxLengthLabelText = ((_form.ImageWidth * (_form.ImageHeight - 1) * 3) / 7) + "  characters.";
        }

        /// <summary>
        /// Exports the text length using the bottom pixels line of the selected image file.
        /// </summary>
        /// <returns>Returns the length of the text.</returns>
        private int ExportTextLength()
        {
            var bitmap = new Bitmap(_form.ExportPictureBoxImage);
            string thirtyBytes = string.Empty, textLength = string.Empty;

            for (int i = 0; i < 10; i++)  // gettint last 30 bytes of the image
            {
                thirtyBytes += Convert.ToString(bitmap.GetPixel(i, _form.ImageHeight - 1).ToArgb(), 2).Substring(8);
            }

            int pointer = 7;
            for (int i = 0; i < 30; i++)   // getting the last bit of the each bytes
            {
                textLength += thirtyBytes.Substring(pointer, 1);
                pointer += 8;
            }

            var textLengthDecimalForm = new char[5];
            int m, tmp = 0, decrease = 0, k = 0;

            for (m = 0; m < textLength.Length / 6; m++)
            {
                for (int n = k; n < k + 6; n++)
                {
                    tmp += Convert.ToInt32(textLength.Substring(n, 1)) * (int)Math.Pow(2, (5 - decrease));
                    decrease++;
                }

                textLengthDecimalForm[m] = Convert.ToChar(tmp);
                k += 6;
                tmp = 0;
                decrease = 0;
            }
            return Convert.ToInt32(new string(textLengthDecimalForm).TrimStart('0'));
        }

        /// <summary>
        /// Exports the text from the selected image file by starting from top left corner.
        /// </summary>
        public void Export()
        {
            _form.ExportTextBoxText = string.Empty;
            _form.Sw = new Stopwatch();
            _form.Sw.Start();
            _form.ExportProgressBarValue = 0;

            var importedTextLength = CheckBeforeExport();
            if (importedTextLength != 0)
            {
                _form.Bmp = new Bitmap(_form.ExportPictureBoxImage);
                int totalBytes = importedTextLength * 7;
                int totalPixels = totalBytes / 3;
                int totalBytesMod3 = totalBytes % 3;
                if (totalBytesMod3 != 0)
                    totalPixels++;
                _form.ExportProgressBarMaximum = importedTextLength + totalPixels;

                var bytesToExport = _helper.GetOnlyNecessaryBytesFromImage(totalPixels, totalBytesMod3, _form.ExpProgressBar);

                int pointer = 7;
                string bytesToExportLast = string.Empty;

                for (int l = 0; l < totalBytes; l++) // Getting the last bit of each bytes and stores to 'bytesToExportast'
                {
                    bytesToExportLast += bytesToExport.Substring(pointer, 1);
                    pointer += 8;
                }

                int decrease = 0, k = 0, temp = 0;
                string importedText = string.Empty;

                for (int j = 0; j < bytesToExportLast.Length / 7; j++)  // 7 bits -> One Character
                {
                    for (int i = k; i < k + 7; i++)
                    {
                        temp += Convert.ToInt32(bytesToExportLast.Substring(i, 1)) * (int)Math.Pow(2, (6 - decrease));
                        decrease++;
                    }

                    if (temp < 13&&Importer.Korean_id==0)
                    {
                        importedText += _helper.NumberToTurkishChar(temp);
                    }
                    else if(temp < 26 && Importer.Korean_id != 0)
                    {
                        importedText += _helper.NumberToKoreanChar(temp);
                    }
                    else
                    {
                        importedText += Encoding.ASCII.GetString(BitConverter.GetBytes(temp)).TrimEnd((Char)0);
                    }

                    _form.ExpProgressBar.Increment(1);
                    k += 7; temp = decrease = 0;
                }

                _form.ExportTextBoxText = importedText;
                SetInfoLabels();
            }
            else
            {
                MessageBox.Show("This is not a stego file!", CommonConstants.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Set process result info on the screen.
        /// </summary>
        private void SetInfoLabels()
        {
            _form.Sw.Stop();
            _form.ExportedTextLengtLabelText = _form.ExportTextBoxText.Length.ToString();
            _form.ExportDurationLabelText = string.Format("{0} mins. {1} secs. {2} msec.", _form.Sw.Elapsed.Minutes, _form.Sw.Elapsed.Seconds, +_form.Sw.Elapsed.Milliseconds);
            _form.ExportTickPictureBoxVisible = true;
        }
    }
}