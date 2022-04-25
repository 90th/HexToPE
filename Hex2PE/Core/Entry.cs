using System;
using System.Globalization;
using System.IO;

namespace Hex2PE.Core {

    internal class Entry {

        // convert byte array from file to hex values
        public static string ConvertByteToHex(byte[] byteData) {
            string hexValues = BitConverter.ToString(byteData).Replace("-", "");

            return hexValues;
        }
        // convert hex values of file back to bytes
        public static byte[] ConvertHexToByteArray(string hexString) {
            byte[] byteArray = new byte[hexString.Length / 2];

            for (int index = 0; index < byteArray.Length; index++) {
                string byteValue = hexString.Substring(index * 2, 2);
                byteArray[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }

            return byteArray;
        }

        private static void Main(string[] args) {
            string StoredHexValues = Hexadecimal.hex;
            // Convert Stored Hex Values to Bytes
            byte[] Bytes2 = ConvertHexToByteArray(StoredHexValues);

            // Save Converted Hex to Bytes as File.
            File.WriteAllBytes(@"HelloWorld.exe", Bytes2);

            Console.Write("\nPress any key to continue...");
            Console.ReadKey();

            StoredHexValues = string.Empty;
            Array.Clear(Bytes2, 0, Bytes2.Length);
        }
    }
}
