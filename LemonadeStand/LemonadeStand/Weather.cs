using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public int weatherType;
        public int temperature;
        public int weatherReliability;
        public int temperatureReliability;
        Random random = new Random();


        public string GetWeather()
        {
            ///this will take the weatherType value and return the corresponding string
            switch (weatherType)
            {
                case 0:
                    return "Sunny and Clear";
                    
                case 1:
                    return "Rain";
                    
                case 2:
                    return "Cloudy";
                    
                case 3:
                    return "Hazy";
                      
                default:
                    return "Sunny and Clear";
                    
            }
        }
        public int GetWeatherReliability()
        {
            ///determines weatherType value based on forecast and random variable to see if it matches forecast.  Chance of this is arbitrary number
            return random.Next(1, 11);
            
        }

        public int GetTemperatureReliability()
        {
            return random.Next(1, 11);
        }

        public int GetWeatherType(int type)
        {
            if (weatherReliability != 10)
            {
                return type;
            } else
            {
                return random.Next(0, 4);
            }

        }

        public int GetTemperature(int temp)
        {
            if (temperatureReliability != 10)
            {
                return temp;
            } else
            {
                return random.Next(60, 101);
            }
        }
    }
}
