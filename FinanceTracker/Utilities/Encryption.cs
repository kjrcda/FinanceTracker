using System;
using System.Security.Cryptography;
using System.Text;

namespace FinanceTracker
{
    public static class Encryption
    {
        private const int KeySize = 256;
        private const int BlockSize = 128;
        private static byte[] _passBytes;
        private static byte[] _initVector;

        public static void Initialize(string password, string vector)
        {
            _passBytes = Encoding.ASCII.GetBytes(password);
            _initVector = Encoding.ASCII.GetBytes(vector);

            _passBytes = _passBytes ?? new byte[0];
            _initVector = _initVector ?? new byte[0];

            var message = string.Empty;
            if (_passBytes.Length == 0)
                message = "Password has not been initialized yet.";

            if (_initVector.Length == 0)
                message += (_passBytes.Length == 0 ? "\n" : "") + "Initial Vector has not been initialized yet.";

            if (!String.IsNullOrEmpty(message))
                System.Windows.Forms.MessageBox.Show(message, "Encryption Keys");
        }

        public static string Encrypt(string plaintext)
        {
            if(!IsPasswordAndVectorValid()) { return plaintext; }

            var ptBytes = Encoding.ASCII.GetBytes(plaintext);
            var aes = new AesCryptoServiceProvider
            {
                BlockSize = BlockSize,
                KeySize = KeySize,
                Key = _passBytes,
                IV = _initVector,
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.CBC
            };

            var crypto = aes.CreateEncryptor(aes.Key, aes.IV);
            var ctBytes = crypto.TransformFinalBlock(ptBytes, 0, ptBytes.Length);
            crypto.Dispose();

            return Convert.ToBase64String(ctBytes);
        }

        public static string Decrypt(string ciphertext)
        {
            if (!IsPasswordAndVectorValid()) { return ciphertext; }

            var ctBytes = Convert.FromBase64String(ciphertext);
            var aes = new AesCryptoServiceProvider
            {
                BlockSize = 128,
                KeySize = 256,
                Key = _passBytes,
                IV = _initVector,
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.CBC
            };

            var crypto = aes.CreateDecryptor(aes.Key, aes.IV);
            var ptBytes = crypto.TransformFinalBlock(ctBytes, 0, ctBytes.Length);
            crypto.Dispose();

            return Encoding.ASCII.GetString(ptBytes);
        }

        private static bool IsPasswordAndVectorValid()
        {
            return !(_passBytes.Length == 0 || _initVector.Length == 0);
        }
    }
}
