using System;
using System.Security.Cryptography;
using System.Text;

namespace Encryption
{
    public static class Encryption
    {
        private static string KeysFilename { get; } = "data.dat";
        public static byte[] Vector { get; } = Encoding.ASCII.GetBytes("D#$rwfa24SGHdf4f");
        public static byte[] Crypto { get; } = Encoding.ASCII.GetBytes("@Why4Not8USE3A2funny0pasSworD%3T");

        private static int KeySize { get; } = 256;
        private static int BlockSize { get; } = 128;

        public static string Encrypt(string plaintext, byte[] passBytes, byte[] initVector)
        {
            if (!IsPasswordAndVectorValid(passBytes, initVector)) { return plaintext; }

            var ptBytes = Encoding.ASCII.GetBytes(plaintext);
            var aes = new AesCryptoServiceProvider
            {
                BlockSize = BlockSize,
                KeySize = KeySize,
                Key = passBytes,
                IV = initVector,
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.CBC
            };

            var crypto = aes.CreateEncryptor(aes.Key, aes.IV);
            var ctBytes = crypto.TransformFinalBlock(ptBytes, 0, ptBytes.Length);
            crypto.Dispose();

            return Convert.ToBase64String(ctBytes);
        }

        public static string Decrypt(string ciphertext, byte[] passBytes, byte[] initVector)
        {
            if (!IsPasswordAndVectorValid(passBytes, initVector)) { return ciphertext; }

            var ctBytes = Convert.FromBase64String(ciphertext);
            var aes = new AesCryptoServiceProvider
            {
                BlockSize = 128,
                KeySize = 256,
                Key = passBytes,
                IV = initVector,
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.CBC
            };

            var crypto = aes.CreateDecryptor(aes.Key, aes.IV);
            var ptBytes = crypto.TransformFinalBlock(ctBytes, 0, ctBytes.Length);
            crypto.Dispose();

            return Encoding.ASCII.GetString(ptBytes);
        }

        private static bool IsPasswordAndVectorValid(byte[] passBytes, byte[] initVector)
        {
            return passBytes.Length > 0 && initVector.Length > 0;
        }
    }
}
