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

        public FDegreesConverter(TotalCDegrees d)
        {
            _CDegrees = d;
        }

        public void ConvertFDegreees(double FDegrees)
        {
            _CDegrees.SetCDegrees(Math.Round((FDegrees-32)/Rate, 2));
        }

        public double GetCDegrees()
        {
            return _CDegrees.GetCDegrees();
        }
    }
}
