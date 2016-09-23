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
        public int forecastReliabilityFactor = 5;
        
        public void SetForecastWeather(int type)
        {
            if (GetForecastReliability() != forecastReliabilityFactor)
            {
                forecastWeather = type;
            } else
            {
                forecastWeather = random.Next(0, 4);
            }
        }
        public string GetForecastWeather()
        {

            switch (forecastWeather)    
            {
                case 0:
                    return "Sunny and Clear";

                case 1:
                    return "Rainy";

                case 2:
                    return "Cloudy";

                case 3:
                    return "Hazy";

                default:
                    return "Sunny and Clear";

            }
        }

        public void SetForecastTemperature(int temperature, int maxTemperature, int minTemperature)
        {
            if (GetForecastReliability() != forecastReliabilityFactor)
            {
                forecastTemperature = temperature;
            } else
            {
                forecastTemperature = random.Next(minTemperature, maxTemperature+1);
            }
        }

        public int GetForecastReliability()
        {
            return random.Next(0, forecastReliabilityFactor+1);
        }

    }
}
