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
        private int CheckBeforeExport() //Export 전에 선택된 파일 체크
        {
            try
            {
                return ExportTextLength(); //ExportTextLenth 반환
            }
            catch
            {
                return 0; // 예외 발생시 0반환
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
                //이미지의 마지막 줄 바로 위의 줄 30바이트 얻음 
            }

            int pointer = 7;
            for (int i = 0; i < 30; i++)   // getting the last bit of the each bytes
                
            {
                textLength += thirtyBytes.Substring(pointer, 1);
                //각 바이트의 7번째 자리 값(즉 LSB비트)를 뽑아서 저장된 메시지의 길이 구함->2진수
                pointer += 8;
            }

            var textLengthDecimalForm = new char[5];
            int m, tmp = 0, decrease = 0, k = 0;

            for (m = 0; m < textLength.Length / 6; m++) //텍스트의 길이를 10진수로 바꿈
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
                } //각 바이트의 마지막 비트를 꺼내서 byteToExportLast에 저장함

                int decrease = 0, k = 0, temp = 0;
                string importedText = string.Empty;

                for (int j = 0; j < bytesToExportLast.Length / 7; j++)  // 7 bits -> One Character, 7 바이트를 하나의 문자열로 바꾸는 부분 
                {
                    for (int i = k; i < k + 7; i++)
                    {
                        temp += Convert.ToInt32(bytesToExportLast.Substring(i, 1)) * (int)Math.Pow(2, (6 - decrease));
                        decrease++;
                    }

                    if (temp < 13&&Importer.Korean_id==0) //꺼낸 아스키값이 13보다 작고, 한국어가 아니면
                    {
                        importedText += _helper.NumberToTurkishChar(temp); //터키어!
                    }
                    else if(temp < 26 && Importer.Korean_id != 0) //꺼낸 아스키값이 26보다 작고 한국어이면
                    {
                        importedText += _helper.NumberToKoreanChar(temp); //한국어!
                    }
                    else //그 밖의 것은

                    {
                        importedText += Encoding.ASCII.GetString(BitConverter.GetBytes(temp)).TrimEnd((Char)0);
                        //그 아스키 값에 해당하는 문자열 꺼냄
                    }

                    _form.ExpProgressBar.Increment(1);
                    k += 7; temp = decrease = 0;
                }

                _form.ExportTextBoxText = importedText; // 폼으로 문자열 바로 꺼냄
                SetInfoLabels();
            }
            else // 추출된 텍스트의 길이가 0이면 Stego 파일이 아니라고 판단
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