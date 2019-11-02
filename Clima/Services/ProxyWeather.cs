using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clima.Models;
using RestSharp;

namespace Clima.Services
{
    class ProxyWeather : IProxyWeather
    {
        private RestClient _client;
        private string appid = "807e039bd90c3a40ac224637ffd000fb";
        private string units = "imperial";

        public ProxyWeather()
        {
            _client = new RestClient("http://api.openweathermap.org/data/2.5/");
        }

        public ForecastObject Forecast(string ciudad)
        {
            var request = new RestRequest($"forecast?q={ciudad}&APPID={appid}&units={units}");
            var response = _client.Get<ForecastObject>(request);
            return response.Data;
        }

        public WeatherObject Weather(string ciudad)
        {
            var request = new RestRequest($"weather?q={ciudad}&APPID={appid}&units={units}");
            var response = _client.Get<WeatherObject>(request);
            return response.Data;
        }
    }
}
