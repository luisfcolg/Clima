using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clima.Models;

namespace Clima.Adapters
{
    class FDegreesConverter : IConverter
    {
        private const double Rate = 1.8;
        private readonly TotalCDegrees _CDegrees;

        public FDegreesConverter()
        {

        }

        public void ConvertFDegreees(double FDegrees)
        {
            _CDegrees.SetCDegrees((FDegrees-32)/Rate);
        }

        public double GetCDegrees()
        {
            return _CDegrees.GetCDegrees();
        }
    }
}
