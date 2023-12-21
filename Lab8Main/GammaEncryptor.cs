using System.Text;

namespace Lab8Main
{
    internal static class GammaEncryptor
    {
        private static int SYMBOL_SIZE = 16;

        private static int BLOCK_SIZE = 32;
        private static int SYMBOLS_IN_BLOCK = BLOCK_SIZE / SYMBOL_SIZE;

        private static UnicodeEncoding unicodeEncoding = new UnicodeEncoding();

        private static byte[] StringToByte(string input)
        {
            return unicodeEncoding.GetBytes(input);
        }

        private static string ByteToString(byte[] bytes)
        {
            return unicodeEncoding.GetString(bytes);
        }

        private static string PadString(string str, int blockSize)
        {
            while (str.Count() % blockSize != 0)
            {
                str = str + " ";
            }

            return str;
        }

        private static string DupeString(string input, int size)
        {
            var sBuilder = new StringBuilder();

            while (sBuilder.Length < size)
            {
                sBuilder.Append(input);
            }

            while (sBuilder.Length > size)
            {
                sBuilder.Remove(sBuilder.Length - 1, 1);
            }

            return sBuilder.ToString();
        }

        private static byte[] XOR(byte[] bytes1, byte[] bytes2)
        {
            if (bytes1.Length != bytes2.Length)
            {
                throw new ArgumentException("Size of byte arrays do not match!");
            }

            var size = bytes1.Count();
            var result = new byte[size];

            for (int i = 0; i < size; ++i)
            {
                result[i] = (byte)(bytes1[i] ^ bytes2[i]);
            }

            return result;
        }

        private static byte[] Encrypt(byte[] input, byte[] key)
        {
            if (input.Count() != key.Count())
            {
                throw new ArgumentException("Key and block sizes do not match!");
            }

            var size = input.Count();
            var result = new byte[size];

            for(int i = 0; i < size; ++i)
            {
                result[i] = Convert.ToByte((input[i] + key[i]) % 256);
            }

            return result;
        }

        private static byte[] Decrypt(byte[] input, byte[] key)
        {
            if (input.Count() != key.Count())
            {
                throw new ArgumentException("Key and block sizes do not match!");
            }

            var size = input.Count();
            var result = new byte[size];

            for (int i = 0; i < size; ++i)
            {
                if (input[i] < key[i])
                {
                    result[i] = Convert.ToByte(input[i] - key[i] + 256);
                }
                else
                {
                    result[i] = Convert.ToByte(input[i] - key[i]);
                }
            }

            return result;
        }

        public static string Encrypt(string input, string key)
        {
            key = DupeString(key, SYMBOLS_IN_BLOCK);
            input = PadString(input, SYMBOLS_IN_BLOCK);
            var byteKey = StringToByte(key);

            var sBuilder = new StringBuilder();

            var blocks = input.Count() / SYMBOLS_IN_BLOCK;

            for (int i = 0; i < blocks; i += 1)
            {
                var block = input.Substring(i * SYMBOLS_IN_BLOCK, SYMBOLS_IN_BLOCK);
                var byteBlock = StringToByte(block);
                var encyptedBlock = Encrypt(byteBlock, byteKey);
                var strBlock = ByteToString(encyptedBlock);
                sBuilder.Append(strBlock);
            }

            return sBuilder.ToString();
        }

        public static string Decrypt(string input, string key)
        {
            key = DupeString(key, SYMBOLS_IN_BLOCK);
            input = PadString(input, SYMBOLS_IN_BLOCK);
            var byteKey = StringToByte(key);

            var sBuilder = new StringBuilder();

            var blocks = input.Count() / SYMBOLS_IN_BLOCK;

            for (int i = 0; i < blocks; i += 1)
            {
                var block = input.Substring(i * SYMBOLS_IN_BLOCK, SYMBOLS_IN_BLOCK);
                var byteBlock = StringToByte(block);
                var encyptedBlock = Decrypt(byteBlock, byteKey);
                var strBlock = ByteToString(encyptedBlock);
                sBuilder.Append(strBlock);
            }

            return sBuilder.ToString();
        }
    }
}
