using System.Security.Cryptography;


namespace Aogami.SMTV.Encryption
{
    public class AesEncryption
    {
        private readonly byte[] _key = { 0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x61, 0x62, 0x63, 0x64, 0x65, 0x66, 0x30, 0x31, 0x32, 0x33, 0x34, 0x35, 0x36, 0x37, 0x38, 0x39, 0x61, 0x62, 0x63, 0x64, 0x65, 0x66 };
        private readonly byte[] _iv = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        private readonly int _keySize;
        private readonly int _blockSize;
        private readonly PaddingMode _paddingMode;
        private readonly CipherMode _cipherMode;

        public AesEncryption(PaddingMode paddingMode = PaddingMode.None, CipherMode cipherMode = CipherMode.ECB)
        {
            _paddingMode = paddingMode;
            _cipherMode = cipherMode;
            _keySize = 256;
            _blockSize = 128;
        }

        private Aes GetAlgorithmObject()
        {
            Aes aesCrypt = Aes.Create();
            aesCrypt.KeySize = _keySize;
            aesCrypt.BlockSize = _blockSize;
            aesCrypt.Padding = _paddingMode;
            aesCrypt.Mode = _cipherMode;
            return aesCrypt;
        }

        private CryptoStream GetDecryptionStream(Stream data)
        {
            using Aes aesCrypt = GetAlgorithmObject();
            aesCrypt.Key = _key;
            aesCrypt.IV = _iv;

            ICryptoTransform decryptor = aesCrypt.CreateDecryptor();
            CryptoStream csDecrypt = new(data, decryptor, CryptoStreamMode.Read);
            return csDecrypt;
        }

        private CryptoStream GetEncryptionStream(Stream data)
        {
            using Aes aesCrypt = GetAlgorithmObject();
            aesCrypt.Key = _key;
            aesCrypt.IV = _iv;

            ICryptoTransform encryptor = aesCrypt.CreateEncryptor();
            CryptoStream csEncrypt = new(data, encryptor, CryptoStreamMode.Write);
            return csEncrypt;
        }

        public async Task<byte[]> Decrypt(byte[] encryptedData)
        {
            using MemoryStream memStream = new(encryptedData);
            using CryptoStream csDecrypt = GetDecryptionStream(memStream);
            using MemoryStream output = new();
            byte[] buffer = new byte[1024];
            int read = await csDecrypt.ReadAsync(buffer);
            while (read > 0)
            {
                await output.WriteAsync(buffer.AsMemory(0, read));
                read = await csDecrypt.ReadAsync(buffer);
            }

            await csDecrypt.FlushAsync();
            return output.ToArray();
        }

        public async Task<byte[]> Encrypt(byte[] decryptedData)
        {
            using MemoryStream memStream = new();
            using CryptoStream csEncrypt = GetEncryptionStream(memStream);
            await csEncrypt.WriteAsync(decryptedData);
            await csEncrypt.FlushFinalBlockAsync();
            return memStream.ToArray();
        }
    }
}
