using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace LogicLayerLibrary
{
    public class HashingLogic
    {
        private static readonly int iterations = 1000;
        public static string GenerateSalt()
        {
            byte[] salt = new byte[32];
            RNGCryptoServiceProvider rngProvider = new RNGCryptoServiceProvider();
            rngProvider.GetBytes(salt);
            string saltstring = Convert.ToBase64String(salt);

            return saltstring;
        }

        public static string GenerateHash(string salt, string password)
        {
            var saltvar = Encoding.UTF8.GetBytes(salt);
            Rfc2898DeriveBytes rfc2898 = new Rfc2898DeriveBytes(password, saltvar, iterations);
            byte[] key = rfc2898.GetBytes(32);
            string keystring = Convert.ToBase64String(key);
            return keystring;
        }

        public static bool CheckPassword(string userSalt, string userHash, string password)
        {
            string Hash = GenerateHash(userSalt, password);
            if (Hash == userHash)
            {
                return true;
            }
            return false;
        }
    }
}
