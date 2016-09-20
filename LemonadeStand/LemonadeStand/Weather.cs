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
        public int maxTemperature = 100;
        public int minTemperature = 60;
        static Random random = new Random();
        public Forecast forecast = new Forecast();


        public string GetWeather()
        {
            ///this will take the weatherType value and return the corresponding string
            switch (weatherType)
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

        public void SetWeatherType()
        {
            weatherType = random.Next(0, 4);
        }
        public void SetTemperature()
        {
            temperature = random.Next(60, 101);
        }
        public int GetWeatherReliability()
        {
            
            return random.Next(1, 6);
            
        }

        public int GetTemperatureReliability()
        {
            return random.Next(1, 6);
        }

        public int GetWeatherType(int type)
        {
            if (weatherReliability != 5)
            {
                return type;
            } else
            {
                return random.Next(0, 4);
            }

        }

        public int GetTemperature(int temp)
        {
            if (temperatureReliability != 5)
            {
                return temp;
            } else
            {
                return random.Next(minTemperature, maxTemperature);
            }
        }
    }
}
