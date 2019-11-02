using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clima.Strategy
{
    class ValidateMailClass
    {
        private readonly IValidateMail _strategy;
        private readonly string _mail;

        public ValidateMailClass(IValidateMail strategy, string mail)
        {
            _strategy = strategy;
            _mail = mail;
        }

        public bool Validate()
        {
            return _strategy.Validate(_mail);
        }
    }
}
