using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Forecast
    {
        public int[] forecastWeather = new int[35];
        public int[] forecastTemperature = new int[35];
        static Random random = new Random();
        
        public void SetForecastWeather()
        {
            for (int i = 0; i < 35; i++)
            {
                forecastWeather[i] = random.Next(0, 4);
            }
        }

        public void PopulateForecast()
        {
            for (int x = 0; x < 35; x++)
            {
                forecastWeather[x] = 0;
                forecastTemperature[x] = 60;
            }
        }

        public void SetForecastTemperature()
        {
            for (int i = 0; i < 35; i++)
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
