using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Forecast
    {
        public int forecastWeather;
        public int forecastTemperature;
        static Random random = new Random();
        
        public void SetForecastWeather(int type)
        {
            if (GetForecastReliability() != 5)
            {
                forecastWeather = type;
            } else
            {
                forecastWeather = random.Next(0, 4);
            }
        }

        public void SetForecastTemperature(int temperature)
        {
            if (GetForecastReliability() != 5)
            {
                forecastTemperature = temperature;
            } else
            {
                forecastTemperature = random.Next(60, 101);
            }
        }

        public int GetForecastReliability()
        {
            return random.Next(0, 6);
        }

    }
}
