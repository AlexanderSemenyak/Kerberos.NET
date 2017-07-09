﻿using Syfuhs.Security.Kerberos.Aes;

namespace Syfuhs.Security.Kerberos.Crypto
{
    internal class AES128Decryptor : AESDecryptor
    {
        private static readonly IEncryptor encryptor = new AES128Encryptor();

        public AES128Decryptor()
            : base(encryptor, new SHA1Hasher())
        {
        }
    }

    internal class AES128Encryptor : AESEncryptor
    {
        public AES128Encryptor()
            : base(16, 16, 16)
        { }
    }
}
