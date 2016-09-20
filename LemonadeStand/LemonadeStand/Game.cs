using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        HumanPlayer player1 = new HumanPlayer();
        Day[] days = new Day[7];
        Forecast forecast = new Forecast();
        UserInterface userInterface = new UserInterface();
        int dayCount;

        public Game()
        {
            dayCount = 0;
        }

        public void GenerateDays()
        {
            for (int x = 0; x < 7; x++)
            {
                days[x] = new Day();
            }
        }

        public void Initialize()
        {
            GenerateDays();
            GenerateWeather();
            GenerateCustomersForWeek();
            RunThroughDay();

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
                days[x].weather.weatherType = days[x].weather.GetWeatherType(forecast.forecastWeather[x]);
            }
        }

        public void SetTemperatureForWeek()
        {
            for (int x = 0; x < 7; x++)
            {
                days[x].weather.temperature = days[x].weather.GetTemperature(forecast.forecastTemperature[x]);
            }
        }

        public void GenerateWeather()
        {
            forecast.PopulateForecast();
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


        public void BuyCups()
        {
            userInterface.DisplayInventory(player1.stand.inventory.numberCups, "cups");
            userInterface.PromptToBuy("cups");
            userInterface.DisplayPricePer(player1.store.priceCups);
            DisplayMoney();
            player1.BuyCups(userInterface.GetNumberValue());
        }

        public void BuyIce()
        {
            userInterface.DisplayInventory(player1.stand.inventory.cubesIce, "ice cubes");
            userInterface.PromptToBuy("ice cubes");
            userInterface.DisplayPricePer(player1.store.priceIce);
            DisplayMoney();
            player1.BuyIce(userInterface.GetNumberValue());
        }

        public void BuyLemons()
        {
            userInterface.DisplayInventory(player1.stand.inventory.numberLemons, "lemons");
            userInterface.PromptToBuy("lemons");
            userInterface.DisplayPricePer(player1.store.priceLemons);
            DisplayMoney();
            player1.BuyLemons(userInterface.GetNumberValue());
        }
        public void BuySugar()
        {
            userInterface.DisplayInventory(player1.stand.inventory.cupsSugar, "cups of sugar");
            userInterface.PromptToBuy("cups of sugar");
            userInterface.DisplayPricePer(player1.store.priceSugar);
            DisplayMoney();
            player1.BuySugar(userInterface.GetNumberValue());
        }

        public void DisplayMoney()
        {
            userInterface.DisplayMoney(Math.Round(player1.stand.inventory.money, 2));
        }

        public void BuyIngredients()
        {
            BuyCups();
            BuyIce();
            BuyLemons();
            BuySugar();
        }

        public void AdvanceDay()
        {
            dayCount += 1;
        }

        public void RunThroughDay()
        {
            while (dayCount < 7)
            {
                BuyIngredients();
                
                DisplayMoney();
                userInterface.DisplayWeather(days[dayCount].weather.GetWeather(), days[dayCount].weather.temperature);
                SetPriceForLemonade();
                RunStandForDay();
                AdvanceDay();
                DisplayMoney();
                Console.ReadLine();
            }
        }

        public void SetPriceForLemonade()
        {
            userInterface.RequestLemonadePrice();
            player1.stand.priceLemonade = userInterface.GetNumberValue();
        }


    }
}
