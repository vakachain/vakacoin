using System;
using System.Linq;

namespace Vakacoin.Core.Helper
{
    public static class ByteArrayHelpers
    {
        private static bool IsWithPrefix(string value)
        {
            return value.Length >= 2 && value[0] == '0' && (value[1] == 'x' || value[1] == 'X');
        }

        public static string ToHex(this byte[] bytes, bool withPrefix=false)
        {
            int offset = withPrefix ? 2 : 0;
            int length = bytes.Length * 2 + offset;
            char[] c = new char[length];

            byte b;

            if (withPrefix)
            {
                c[0] = '0';
                c[1] = 'x';                
            }

            for (int bx = 0, cx = offset; bx < bytes.Length; ++bx, ++cx)
            {
                b = ((byte) (bytes[bx] >> 4));
                c[cx] = (char) (b > 9 ? b + 0x37 + 0x20 : b + 0x30);

                b = ((byte) (bytes[bx] & 0x0F));
                c[++cx] = (char) (b > 9 ? b + 0x37 + 0x20 : b + 0x30);
            }

            return new string(c);
        }

        public static byte[] FromHexString(string hex)
        {
            if (IsWithPrefix(hex))
                hex = hex.Substring(2);
            int numberChars = hex.Length;
            byte[] bytes = new byte[numberChars / 2];

            for (int i = 0; i < numberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);

            return bytes;
        }

        public static bool BytesEqual(this byte[] b1, byte[] b2)
        {
            if (b1 == b2)
                return true;

            if (b1 == null || b2 == null)
                return false;

            if (b1.Length != b2.Length)
                return false;

            for (var i = 0; i < b1.Length; i++)
            {
                if (b1[i] != b2[i]) return false;
            }

            return true;
        }

        public static byte[] RandomFill(int count)
        {
            Random rnd = new Random();
            byte[] random = new byte[count];

            rnd.NextBytes(random);

            return random;
        }
        
        public static byte[] Combine(params byte[][] arrays)
        {
            byte[] rv = new byte[arrays.Sum(a => a.Length)];
            int offset = 0;
            foreach (byte[] array in arrays) {
                Buffer.BlockCopy(array, 0, rv, offset, array.Length);
                offset += array.Length;
            }
            return rv;
        }
    }
}