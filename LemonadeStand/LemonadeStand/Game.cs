using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        HumanPlayer player1;
        Day[] days = new Day[7];
        Forecast forecast = new Forecast();
        UserInterface userInterface = new UserInterface();
        int dayCount;

        public Game()
        {
            dayCount = 1;
        }

        public void PlayGame()
        {
            GenerateWeather();
            GenerateCustomersForWeek();

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
        public void GenerateCustomersForWeek()
        {
            for (int x = 0; x < 7; x++)
            {
                days[x].GenerateCustomers();
            }
        }
        
        public void RunStandForDay()
        {
            foreach (Customer customer in days[dayCount].customers)
            {
                if (customer.actualPriceWillingToPay >= player1.stand.priceLemonade && player1.stand.inventory.numberCups > 0)
                {
                        if (player1.stand.inventory.cupsOfLemonadeLeftInPitcher > 0)
                        {
                            player1.stand.SellLemonade();
                        }
                        else if (player1.stand.inventory.cupsSugar > 3 && player1.stand.inventory.numberLemons > 3 && player1.stand.inventory.cubesIce > 19)
                        {
                            player1.stand.MakeLemonade();
                            player1.stand.SellLemonade();
                        }
                }
            }
        }
    }
}
