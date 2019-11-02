using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clima.Models
{
    public class TotalCDegrees
    {
        private double _cdegrees;

        public TotalCDegrees()
        {

        }

        public void SetCDegrees(double c)
        {
            _cdegrees = c;
        }

        public double GetCDegrees()
        {
            return _cdegrees;
        }
    }
}
