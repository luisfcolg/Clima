using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Clima.Helper
{
    class PasswordHashSingleton
    {
        // 24 = 192 bits
        private const int SaltByteSize = 24;
        private const int HashByteSize = 24;
        private const int HasingIterationsCount = 10101;

        private PasswordHashSingleton()
        {

        }

        private static PasswordHashSingleton _instance;

        private static PasswordHashSingleton GetInstance()
        {
            if (_instance == null)
                _instance = new PasswordHashSingleton();

            return _instance;
        }

        internal static byte[] GenerateSalt(int saltByteSize = SaltByteSize)
        {
            using (RNGCryptoServiceProvider saltGenerator = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[saltByteSize];
                saltGenerator.GetBytes(salt);
                return salt;
            }
        }

        internal static byte[] ComputeHash(string password, byte[] salt, int iterations = HasingIterationsCount, int hashByteSize = HashByteSize)
        {
            using (Rfc2898DeriveBytes hashGenerator = new Rfc2898DeriveBytes(password, salt))
            {
                hashGenerator.IterationCount = iterations;
                return hashGenerator.GetBytes(hashByteSize);
            }
        }

        /*
        //To base64 string from bytes
        password.PasswordSalt = Convert.ToBase64String(passwordSaltKey);
 
        //To bytes from base64 string
        byte[] passwordSalt = Convert.FromBase64String(passwordSaltKey);
        */
    }
}
