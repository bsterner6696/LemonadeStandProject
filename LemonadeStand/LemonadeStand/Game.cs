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
                        else if (player1.stand.inventory.cupsSugar >= player1.stand.recipe.requiredCupsOfSugar && player1.stand.inventory.numberLemons >= player1.stand.recipe.requiredLemons && player1.stand.inventory.cubesIce >= player1.stand.recipe.requiredIceCubes)
                        {
                            player1.stand.MakeLemonade();
                            player1.stand.SellLemonade();
                        }
                }
            }
        }


        public void ShopForCups()
        {
            userInterface.DisplayInventory(player1.stand.inventory.numberCups, "cups");
            userInterface.PromptToBuy("cups");
            userInterface.DisplayPricePer(player1.store.priceCups);
            DisplayMoney();
            BuyCups();
            
        }

        public void BuyCups()
        {
            int amount = userInterface.GetNumberValue();
            if (amount * player1.store.priceCups <= player1.stand.inventory.money)
            {

                player1.BuyCups(amount);
            } else
            {
                BuyCups();
            }
        }


        public void ShopForIce()
        {
            userInterface.DisplayInventory(player1.stand.inventory.cubesIce, "ice cubes");
            userInterface.PromptToBuy("ice cubes");
            userInterface.DisplayPricePer(player1.store.priceIce);
            DisplayMoney();
            BuyIce();
            
        }

        public void BuyIce()
        {
            int amount = userInterface.GetNumberValue();
            if (amount * player1.store.priceIce <= player1.stand.inventory.money)
            {

                player1.BuyIce(amount);
            } else
            {
                BuyIce();
            }
        }

        public void ShopForLemons()
        {
            userInterface.DisplayInventory(player1.stand.inventory.numberLemons, "lemons");
            userInterface.PromptToBuy("lemons");
            userInterface.DisplayPricePer(player1.store.priceLemons);
            DisplayMoney();
            BuyLemons();
        }

        public void BuyLemons()
        {
            int amount = userInterface.GetNumberValue();
            if (amount * player1.store.priceLemons <= player1.stand.inventory.money)
            {

                player1.BuyLemons(amount);
            } else
            {
                BuyLemons();
            }
        }
        public void ShopForSugar()
        {
            userInterface.DisplayInventory(player1.stand.inventory.cupsSugar, "cups of sugar");
            userInterface.PromptToBuy("cups of sugar");
            userInterface.DisplayPricePer(player1.store.priceSugar);
            DisplayMoney();
            BuySugar();
        }

        public void BuySugar()
        {
            int amount = userInterface.GetNumberValue();
            if (amount * player1.store.priceSugar <= player1.stand.inventory.money)
            {

                player1.BuySugar(amount);
            } else
            {
                BuySugar();
            }
        }

        public void DisplayMoney()
        {
            userInterface.DisplayMoney(Math.Round(player1.stand.inventory.money, 2));
        }

        public void BuyIngredients()
        {
            ShopForCups();
            ShopForIce();
            ShopForLemons();
            ShopForSugar();
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
