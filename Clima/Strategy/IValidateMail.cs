﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clima.Strategy
{
    interface IValidateMail
    {
        bool Validate(string mail);
    }
}
