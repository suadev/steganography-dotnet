using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Steganography
{

    public class Importer
    {
        public static int Korean_id = 0;
        private MainForm _form;
        private Helper _helper;
        public int Korea_First_Index = 44032; //한국어를 입력하면 나오는 최소 유니코드 (Minimum UNICODE when you type Korean)
        public Importer(MainForm form)
        {
            _form = form;
            _helper = new Helper(_form);
        }

        /// <summary>
        /// Checks selected file before starting the process
        /// import를 시작하기 전에 선택된 파일 검사
        /// </summary>
        /// <returns></returns>
        private bool CheckBeforeImport()
        {
            if (_form.ImageHeight == 0) // 이미지 높이가 0인지 검사(Check if image height is 0)
            {

                MessageBox.Show("Open an image file!", CommonConstants.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (((_form.ImageWidth * (_form.ImageHeight - 1) * 3) / 7) < _form.ImportTextBoxText.Length) // (가로 * (세로-1)*3)/7 < ImportTextBoxText 검사 50/50일때 335<길이
            {
                MessageBox.Show("Too much text for the selected image!", CommonConstants.WarningCaption, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Sets selected file info on the form.
        /// 선택된 파일의 정보 설정 (파일의 정보를 변수에 넣어줌)
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
        /// 선택된 이미지 파일의 마지막 줄의 픽셀을 이용해 텍스트의 길이를 가져온다.
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

            while (30 > counter) // (max. 99999 chars means max 30 bytes(최대 9999chars는 최대 30바이트 의미)) 
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
        /// 선택된 이미지파일에 왼쪽위 코너부터 시작해서 text를 import합니다.
        /// </summary>
        public void Import()
        {
            //ProgressBar용
            _form.Sw = new Stopwatch();
            _form.Sw.Start();
            _form.ImportProgressBarValue = 0;

            if (CheckBeforeImport()) // 50/50일때 335보다 텍스트길이가 짧으면 시작
            {
                string bitsToImport = string.Empty;
                var charsToImport = _form.ImportTextBoxText.ToCharArray();
                var totalBytes = charsToImport.Length * 7;
                var totalPixels = totalBytes / 3; // Total number of pixels to be used..
                var totalBytesMod3 = totalBytes % 3;
                if (totalBytesMod3 != 0)
                    totalPixels++;
                _form.ImportProgressBarMaximum = totalPixels + totalBytes;

                var charToBits = "";//+++

                foreach (var chr in charsToImport)// bitsToImport holds the bit form of the character that will be imported.
                { // ImportTextBoxText를 char을 iterator로 하나씩 돌음



                    if (chr >= Korea_First_Index) //chr이 한국어면 (if chr is Korean)
                    {
                        charToBits = Convert.ToString(chr - Korea_First_Index+1000, 2);
                        //chr - Korean_First_Index는 16비트를 14비트로 줄이기 위해 (Chr - Korean_First_Index is to reduce 16 bits to 14 bits)
                        //1000을더하는 이유는 chr값이 0부터 시작하면 터키어와 겹치기때문(The reason that add 1000 to text is to protect overlapping with turkish).

                    }

                    else
                    {
                        charToBits = Convert.ToString(chr, 2); // 한국어가 아니면 그냥 2진수로 바꿈 (if chr is not Korean, change to binary)

                    }

                    if (charToBits.Length > 7 && charToBits.Length < 9) // 바꾼 2진수가 7과 9 사이라면 (if it's binary is between 7 and 9)
                    {
                        bitsToImport += _helper.TurkishCharTo7Bit(chr); // 터키글자셋에서 14비트로 맞춤 (set to 14 bits in Turkish letter)

                    }
                    else
                    {
                        bitsToImport += charToBits.PadLeft(14, '0'); //14비트가 안되면 앞을 0으로 패딩 (If less than 14 bits, padding the leading 0)

                    }
                }


                var imageBits = _helper.GetOnlyNecessaryBytesFromImage(totalPixels, totalBytesMod3, _form.ImpProgressBar);
                // imageBits는 이미지의 왼쪽아래(0,높이)에서 RGB값을 비트나열로 가져온 값.
                int sevenBitPointer = 0, oneBitPointer = 0;
                var imageBitsLast = string.Empty;

                //입력한 문자열(7bit)을 bit로 만들어서 8비트씩 나열함



                while (bitsToImport.Length > oneBitPointer) //bitsToImport is importing into imagebits. the result is stored in imageBitLast.
                {
                    imageBitsLast += imageBits.Substring(sevenBitPointer, 6) + (bitsToImport.Substring(oneBitPointer, 2));//int.parse remove
                    oneBitPointer = oneBitPointer + 2;
                    sevenBitPointer += 8;
                    _form.ImpProgressBar.Increment(1);
                }

                // Import할 Text 길이 가져오기
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