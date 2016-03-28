using System;
using System.Security.Cryptography;
using System.Text;

namespace FinanceTracker
{
    public static class Encryption
    {
        private static readonly byte[] InitVector = Encoding.ASCII.GetBytes("D#$rwfa24SGHdf4f");
        private const int KeySize = 256;
        private const int BlockSize = 128;
        private static readonly byte[] PassBytes = Encoding.ASCII.GetBytes("@Why4Not8USE3A2funny0pasSworD%3T");

        public static string Encrypt(string plaintext)
        {
            var ptBytes = Encoding.ASCII.GetBytes(plaintext);
            var aes = new AesCryptoServiceProvider
            {
                BlockSize = BlockSize,
                KeySize = KeySize,
                Key = PassBytes,
                IV = InitVector,
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
            var ctBytes = Convert.FromBase64String(ciphertext);
            var aes = new AesCryptoServiceProvider
            {
                BlockSize = 128,
                KeySize = 256,
                Key = PassBytes,
                IV = InitVector,
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.CBC
            };

            var crypto = aes.CreateDecryptor(aes.Key, aes.IV);
            var ptBytes = crypto.TransformFinalBlock(ctBytes, 0, ctBytes.Length);
            crypto.Dispose();

            return Encoding.ASCII.GetString(ptBytes);
        }
    }
}
