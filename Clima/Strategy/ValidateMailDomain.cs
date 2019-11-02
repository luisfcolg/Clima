using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clima.Strategy
{
    class ValidateMailDomain : IValidateMail
    {
        public bool Validate(string mail)
        {
            string[] parts = mail.Split('@');
            string[] domain = parts[1].Split('.');

            if (domain.Length == 1)
                return false;

            foreach (var i in domain)
                if (i.Length == 0)
                    return false;

            return true;
        }
    }
}
