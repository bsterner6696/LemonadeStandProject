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
        Forecast forecast = new Forecast();
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
                    
                case 4:
                    return "Overcast";
                    
                default:
                    return "Sunny and Clear";
                    
            }
        }
        public void SetWeather()
        {
            ///determines weatherType value based on forecast and random variable to see if it matches forecast.  Chance of this is arbitrary number
        }
    }
}
