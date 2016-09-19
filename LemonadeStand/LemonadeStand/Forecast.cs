using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Forecast
    {
        int[] forecastWeather;
        int[] forecastTemperature;
        Random random = new Random();
        
        public void SetForecastWeather()
        {
            ///randomly determines forecast for a given day.  The forecast for the entire game is determined at bootup, but only the next 7 days can be seen.  Each type of weather corresponds to a matching number value.
            for (int i = 0; i < 7; i++)
            {
                forecastWeather[i] = random.Next(0, 4);
            }
        }

        public void SetForecastTemperature()
        {
            for (int i = 0; i < 7; i++)
            {
                forecastTemperature[i] = random.Next(60, 101);
            }
        }
        public void DeclareForecast()
        {
            ///a method for checking the forecast for the next 7 days, probably uses WriteLine or something similar.
        }
    }
}
