using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clima.Models;
using Clima.Services;

namespace Clima
{
    public partial class Form1 : Form
    {
        List<string> cities = new List<string>();

        public Form1()
        {
            InitializeComponent();

            LoadCities();
        }

        private void LoadCities()
        {
            IProxyCountry proxy = new ProxyCountry();
            var countries = proxy.Countries();

            foreach (var i in countries)
                cities.Add(i.capital);
        }
    }
}
