using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Text;

namespace MyApplication.Utilities
{
    public class PasswordEncrypter
    {
        private const char SALT_SEPERATOR = '$';
        private const int SALT_BYTES_LENGTH = 256 / 16;

        //Generate Complete Password Hash
        public static string GeneratePasswordHash(string password)
        {
            var salt = GenerateSalt();

            //Hash the provided password with salt
            string hash = GetPasswordHash(password, salt);

            return CombineSaltWithHash(salt, hash);
        }

        //verify Hashed Password and provided plain-text password
        public static bool VerifyHashedPassword(string providedPassword, string hashedPassword)
        {
            if (providedPassword == null || hashedPassword == null)
                return false;

            var components = hashedPassword.Split(SALT_SEPERATOR);

            if (components.Length == 2)
            {
                var saltComponent = Encoding.ASCII.GetBytes(components[0]);
                var hashComponent = components[1];

                var generatedHash = GetPasswordHash(providedPassword, saltComponent);

                if (hashComponent == generatedHash)
                {
                    return true;
                }

            }

            return false;
        }

        // Generate a random Salt of SALT_BYTES_LENGTH (16 characters)
        // ASCII Safe Charcters
        private static byte[] GenerateSalt()
        {
            char[] chars = "%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ=".ToCharArray();
            var random = new Random();
            var sb = new StringBuilder();
            for (int i = 0; i < SALT_BYTES_LENGTH; i++)
            {
                int num = random.Next(0, chars.Length);
                sb.Append(chars[num]);
            }
            return Encoding.ASCII.GetBytes(sb.ToString());
        }

        //Combine salt with the password
        private static string CombineSaltWithHash(byte[] salt, string hash)
        {
            var saltString = Encoding.ASCII.GetString(salt);
            return saltString + SALT_SEPERATOR + hash;
        }

        //Create a hash component from the provided password and salt
        private static string GetPasswordHash(string password, byte[] salt)
        {
            return Convert.ToBase64String(KeyDerivation.Pbkdf2(password: password, salt: salt,
                            prf: KeyDerivationPrf.HMACSHA512, iterationCount: 10000,
                            numBytesRequested: SALT_BYTES_LENGTH));
        }

    }
}
