using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clima.Strategy
{
    class ValidateMailAt : IValidateMail
    {
        public bool Validate(string mail)
        {
            string[] parts = mail.Split('@');

            if (parts.Length != 2)
                return false;

            if (parts[0].Length == 0 | parts[1].Length == 0)
                return false;

            return true;
        }
    }
}
