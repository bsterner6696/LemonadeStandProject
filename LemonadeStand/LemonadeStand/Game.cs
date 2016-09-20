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
        Day[] days = new Day[35];
        Forecast forecast = new Forecast();
        UserInterface userInterface = new UserInterface();
        Store store = new Store();
        int dayCount;
        int cupsBefore;

        public Game()
        {
            dayCount = 0;
        }

        public void GenerateDays()
        {
            for (int x = 0; x < 35; x++)
            {
                days[x] = new Day();
            }
        }

        public void Initialize()
        {
            GenerateDays();
            GenerateWeather();
            GenerateCustomersForWeek();
            userInterface.DisplayWelcomeMessage();
            Console.ReadLine();
            Console.Clear();
            LoopThroughDays();

        }


        public void SetWeatherForWeek()
        {
            for (int x = 0; x < 7; x++)
            {
                days[x].weather.SetWeatherType();
            }
        }

        public void SetWeatherForecastForWeek()
        {
            for (int x = 0; x < 7; x++)
            {
                days[x].weather.forecast.SetForecastWeather(days[x].weather.weatherType);
            }
        }

        public void SetTemperatureForecastForWeek()
        {
            for (int x = 0; x < 7; x++)
            {
                days[x].weather.forecast.SetForecastTemperature(days[x].weather.temperature);
            }
        }
        public void SetTemperatureForWeek()
        {
            for (int x = 0; x < 7; x++)
            {
               days[x].weather.SetTemperature();
            }
        }

        public void GenerateWeather()
        {
            SetWeatherForWeek();
            SetTemperatureForWeek();
            SetWeatherForecastForWeek();
            SetTemperatureForecastForWeek();
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
            userInterface.DisplayPricePer(store.priceCups);
            DisplayMoney();
            BuyCups();
            
        }

        public void BuyCups()
        {
            int amount = userInterface.GetNumberValue();
            if (amount * store.priceCups <= player1.stand.inventory.money)
            {

                player1.BuyCups(amount, store.priceCups);
            } else
            {
                BuyCups();
            }
        }


        public void ShopForIce()
        {
            userInterface.DisplayInventory(player1.stand.inventory.cubesIce, "ice cubes");
            userInterface.PromptToBuy("ice cubes");
            userInterface.DisplayPricePer(store.priceIce);
            DisplayMoney();
            BuyIce();
            
        }

        public void BuyIce()
        {
            int amount = userInterface.GetNumberValue();
            if (amount * store.priceIce <= player1.stand.inventory.money)
            {

                player1.BuyIce(amount, store.priceIce);
            } else
            {
                BuyIce();
            }
        }

        public void ShopForLemons()
        {
            userInterface.DisplayInventory(player1.stand.inventory.numberLemons, "lemons");
            userInterface.PromptToBuy("lemons");
            userInterface.DisplayPricePer(store.priceLemons);
            DisplayMoney();
            BuyLemons();
        }

        public void BuyLemons()
        {
            int amount = userInterface.GetNumberValue();
            if (amount * store.priceLemons <= player1.stand.inventory.money)
            {

                player1.BuyLemons(amount, store.priceLemons);
            } else
            {
                BuyLemons();
            }
        }
        public void ShopForSugar()
        {
            userInterface.DisplayInventory(player1.stand.inventory.cupsSugar, "cups of sugar");
            userInterface.PromptToBuy("cups of sugar");
            userInterface.DisplayPricePer(store.priceSugar);
            DisplayMoney();
            BuySugar();
        }

        public void BuySugar()
        {
            int amount = userInterface.GetNumberValue();
            if (amount * store.priceSugar <= player1.stand.inventory.money)
            {

                player1.BuySugar(amount, store.priceSugar);
            } else
            {
                BuySugar();
            }
        }

        public void DisplayMoney()
        {
            userInterface.DisplayMoney(string.Format("{0:0.00}", Math.Round(player1.stand.inventory.money, 2)));
        }

        public void BuyIngredients()
        {
            ShopForCups();
            Console.Clear();
            ShopForIce();
            Console.Clear();
            ShopForLemons();
            Console.Clear();
            ShopForSugar();
            Console.Clear();
        }

        public void AdvanceDay()
        {
            dayCount += 1;
        }

        public void LoopThroughDays()
        {
            while (dayCount < 7)
            {
                days[dayCount].GoThroughDay(RunThroughDay);
            }
        }

        public void RunThroughDay()
        {
            DisplayForecast(); 
            Console.ReadLine();
            Console.Clear();
            DisplayMoney(); 
            userInterface.DisplayWeather(days[dayCount].weather.GetWeather(), days[dayCount].weather.temperature); 
            SetPriceForLemonade();
            Console.Clear();
            BuyIngredients(); 
            StoreNumberCups();             
            RunStandForDay();
            userInterface.AnnounceEndOfDay(dayCount + 1);
            DisplayCupsSold();
            DisplayMoney();
            AdvanceDay(); 
            ResetInventory();
            userInterface.DisplayIceMelted();   
            Console.ReadLine();
            Console.Clear();
        }

        public void SetPriceForLemonade()
        {
            userInterface.RequestLemonadePrice();
            player1.stand.priceLemonade = userInterface.GetNumberValue();
        }

        public void DisplayForecast()
        {
            userInterface.AnnounceForecast();
            for (int x = dayCount; x < dayCount + 7; x++)
            {
                userInterface.DisplayForecast(days[x + 1].weather.forecast.forecastWeather, days[x + 1].weather.forecast.forecastTemperature, x + 2);
            }

        }

        public void StoreNumberCups()
        {
            cupsBefore = player1.stand.inventory.numberCups;
        }

        public void DisplayCupsSold()
        {
            userInterface.DisplayCupsSold(cupsBefore - player1.stand.inventory.numberCups);
        }

        public void ResetInventory()
        {
            player1.stand.inventory.iceCubes.Clear();
            player1.stand.inventory.cubesIce = 0;
            player1.stand.inventory.cupsOfLemonadeLeftInPitcher = 0;
        }
    }
}
