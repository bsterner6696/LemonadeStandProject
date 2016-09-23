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
        public int maxTemperature = 100;
        public int minTemperature = 60;
        static Random random = new Random();
        public Forecast forecast = new Forecast();


        public string GetWeather()
        {
            
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
            temperature = random.Next(minTemperature, maxTemperature+1);
        }
        
    }
}
