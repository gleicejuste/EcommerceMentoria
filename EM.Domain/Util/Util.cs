using System;
using System.Security.Cryptography;

namespace EM.Domain.Util
{
    public class Util
    {
        private static readonly RandomNumberGenerator randomNumberGenerator = RandomNumberGenerator.Create();

        public static string GerarHashSenha(string senha)
        {
        
            byte[] salt = new byte[16];
            randomNumberGenerator.GetBytes(salt);

            var pbkdf2 = new Rfc2898DeriveBytes(senha, salt, 1000);

            byte[] hash = pbkdf2.GetBytes(20);
            byte[] hashBytes = new byte[36];

            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            return Convert.ToBase64String(hashBytes);
        }

    }
}
