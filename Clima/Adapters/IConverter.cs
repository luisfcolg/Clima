using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clima.Adapters
{
    public interface IConverter
    {
        void ConvertFDegreees(double FDegrees);
        double GetCDegrees();
    }
}
