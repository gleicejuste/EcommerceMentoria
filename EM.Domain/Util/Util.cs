using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Security.Cryptography;

namespace EM.Domain.Util
{
    public class Util
    {
        private static readonly RandomNumberGenerator rng = RandomNumberGenerator.Create();
        public static string GerarHashSenha(string password)
        {
            const KeyDerivationPrf Pbkdf2Prf = KeyDerivationPrf.HMACSHA1; 
            const int Pbkdf2IterCount = 1000; 
            const int Pbkdf2SubkeyLength = 256 / 8; 
            const int SaltSize = 128 / 8; 
          
            byte[] salt = new byte[SaltSize];
            rng.GetBytes(salt);
            byte[] subkey = KeyDerivation.Pbkdf2(password, salt, Pbkdf2Prf, Pbkdf2IterCount, Pbkdf2SubkeyLength);

            var outputBytes = new byte[1 + SaltSize + Pbkdf2SubkeyLength];
            outputBytes[0] = 0x00; 
            Buffer.BlockCopy(salt, 0, outputBytes, 1, SaltSize);
            Buffer.BlockCopy(subkey, 0, outputBytes, 1 + SaltSize, Pbkdf2SubkeyLength);
            return Convert.ToBase64String(outputBytes);
        }
    }
}
