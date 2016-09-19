using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Player player;
        Day[] days = new Day[7];
        Forecast forecast = new Forecast();

        public void PlayGame()
        {
            ///go through order of game, just call functions for the most part
            GenerateWeather();

        }

        public void GenerateForecast()
        {
            forecast.SetForecastWeather();
            forecast.SetForecastTemperature();
        }
        public void SetWeatherReliabilityForWeek()
        {
            for (int x = 0; x < 7; x++)
            {
                days[x].weather.weatherReliability = days[x].weather.GetWeatherReliability();
            }
        }
        public void SetTemperatureReliabilityForWeek()
        {
            for (int x = 0; x < 7; x++)
            {
                days[x].weather.temperatureReliability = days[x].weather.GetTemperatureReliability();
            }
        }
        public void SetWeatherForWeek()
        {
            for (int x = 0; x < 7; x++)
            {
                days[x].weather.weatherType = days[x].weather.GetWeatherType(days[x].weather.weatherReliability);
            }
        }

        public void SetTemperatureForWeek()
        {
            for (int x = 0; x < 7; x++)
            {
                days[x].weather.temperature = days[x].weather.GetTemperature(days[x].weather.temperatureReliability);
            }
        }

        public void GenerateWeather()
        {
            GenerateForecast();
            SetWeatherReliabilityForWeek();
            SetTemperatureReliabilityForWeek();
            SetWeatherForWeek();
            SetTemperatureForWeek();
        }
    }
}
