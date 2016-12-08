using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Steganography
{
    public class Helper
    {
        private MainForm _form;

        public Helper(MainForm form)
        {
            _form = form;
        }

        /// <summary>
        /// Covnerts string to byte array
        /// </summary>
        /// <param name="binary"></param>
        /// <returns></returns>
        public byte[] StringToByteArray(string binary)
        {
            var list = new List<byte>();
            for (int i = 0; i < binary.Length; i += 8)
            {
                list.Add(Convert.ToByte(binary.Substring(i, 8), 2));
            }
            return list.ToArray();
        }

        /// <summary>
        /// Creates a bitmap object from byte array
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public Bitmap ByteArrayToBitmap(byte[] data)
        {
            int index = 0;
            var bitmap = new Bitmap(_form.Bmp);
            var colorsArray = new Color[data.Length / 3];

            for (int i = 0; i < data.Length - 2; i += 3)
            {
                colorsArray[index] = Color.FromArgb(data[i], data[i + 1], data[i + 2]);
                index++;
            }

            int counter = 0, x = 0, keep = 0, y;
            index = 0;

            for (y = 0; y < _form.ImageHeight; y++)
            {
                for (x = 0; x < _form.ImageWidth; x++)
                {
                    if (counter == colorsArray.Length)
                    {
                        keep = y;
                        y = _form.ImageHeight;
                        break;
                    }
                    counter++;
                    bitmap.SetPixel(x, y, colorsArray[index]);
                    index++;
                }
            }

            if (data.Length % 3 == 1) // Fixing, if all bytes of the latest pixel were not used.
            {
                bitmap.SetPixel(x, keep, Color.FromArgb(data[3 * counter], bitmap.GetPixel(x, keep).R, bitmap.GetPixel(x, keep).B));
            }
            else if (data.Length % 3 == 2)
            {
                bitmap.SetPixel(x, keep, Color.FromArgb(data[3 * counter], data[(3 * counter) + 1], bitmap.GetPixel(x, keep).B));
            }
            return bitmap;
        }

        public string TurkishCharTo7Bit(char turkishChar)
        {
            if (turkishChar == 'ş')
                return "00000000000000";
            if (turkishChar == 'Ş')
                return "00000000000001";
            if (turkishChar == 'ç')
                return "00000000000010";
            if (turkishChar == 'Ç')
                return "00000000000011";
            if (turkishChar == 'ğ')
                return "00000000000100";
            if (turkishChar == 'Ğ')
                return "00000000000101";
            if (turkishChar == 'ü')
                return "00000000000110";
            if (turkishChar == 'Ü')
                return "00000000000111";
            if (turkishChar == 'ö')
                return "00000000001000";
            if (turkishChar == 'Ö')
                return "00000000001001";
            if (turkishChar == '\n')
                return "00000000001010";
            if (turkishChar == 'İ')
                return "00000000001011";
            if (turkishChar == 'ı')
                return "00000000001100";
            return "?";
        }

        public char NumberToTurkishChar(int number)
        {
            if (number == 0)
                return 'ş';
            if (number == 1)
                return 'Ş';
            if (number == 2)
                return 'ç';
            if (number == 3)
                return 'Ç';
            if (number == 4)
                return 'ğ';
            if (number == 5)
                return 'Ğ';
            if (number == 6)
                return 'ü';
            if (number == 7)
                return 'Ü';
            if (number == 8)
                return 'ö';
            if (number == 9)
                return 'Ö';
            if (number == 10)
                return '\n';
            if (number == 11)
                return 'İ';
            if (number == 12)
                return 'ı';
            return '?';
        }

        /// <summary>
        /// Gets the necessary bytes starting from top left corner of the image.
        /// </summary>
        /// <param name="totalPixel"></param>
        /// <param name="bar"></param>
        /// <param name="totalBytesMod3"></param>
        public string GetOnlyNecessaryBytesFromImage(int totalPixel, int totalBytesMod3, ProgressBar bar)
        {
            var bits = string.Empty;
            var counter = 0;
            for (var y = 0; y < _form.ImageHeight; y++)
            {
                for (var x = 0; x < _form.ImageWidth; x++)
                {
                    bar.Increment(1);
                    if (counter == totalPixel)
                    {
                        y = _form.ImageHeight;
                        break;
                    }
                    counter++;
                    bits += Convert.ToString(_form.Bmp.GetPixel(x, y).ToArgb(), 2).Substring(8);
                }
            }
            if (totalBytesMod3 == 0)
                return bits;

            var unusedBytesOfLastPixel = (3 - (totalBytesMod3)); // the number of unused bytes of last pixel
            bits = bits.Remove(8 * totalPixel * 3 - unusedBytesOfLastPixel * 8); // trimming unused bytes of the last pixel 
            return bits;
        }
    }
}
