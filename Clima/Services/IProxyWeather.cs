using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clima.Models;

namespace Clima.Services
{
    interface IProxyWeather
    {
        WeatherObject Weather(string ciudad);
        ForecastObject Forecast(string ciudad);
    }
}
