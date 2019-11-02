using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clima.Models;
using System.Security.Cryptography;

namespace Clima.PasswordHelper
{
    public class SHA1Builder : PasswordBuilder
    {
        public SHA1Builder(string password)
        {
            _password = new Password { PasswordString = password };
        }

        public override void GenerateBytes()
        {
            _password.Bytes = Encoding.Unicode.GetBytes(_password.PasswordString);
        }

        public override void GenerateHashBytes()
        {
            _password.HashBytes = HashAlgorithm.Create("SHA1").ComputeHash(_password.Bytes);
        }

        public override void GenerateHashString()
        {
            _password.HashString = Convert.ToBase64String(_password.HashBytes);
        }
    }
}
