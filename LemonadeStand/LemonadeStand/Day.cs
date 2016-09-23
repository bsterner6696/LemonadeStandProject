using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Reflection;

namespace LemonadeStand
{
    public class Day
    {
        public int dayNumber;
        public List<Customer> customers = new List<Customer>();
        public Weather weather = new Weather();
        static Random random = new Random();
        public int numberOfCustomers;
        public int maxNumberOfCustomers = 120;
        public int minNumberOfCustomers = 70;
        public int defaultNumberOfCustomers = 70;
        public Day()
        {
            numberOfCustomers = defaultNumberOfCustomers;
        }
        
        public void GetNumberOfCustomers()
        {
            numberOfCustomers = random.Next(minNumberOfCustomers, maxNumberOfCustomers);
        }

        public void PopulateCustomers()
        {
            for (int x = 0; x < numberOfCustomers; x++)
            {
                customers.Add(new Customer());
            }
        }

        public void SetCustomerMood()
        {
            for (int x = 0; x < numberOfCustomers; x++)
            {
                customers[x].SetMoodModifier();
            }
        }
        
        public void SetCustomerWeatherModifiers()
        {
            for (int x = 0; x < numberOfCustomers; x++)
            {
                customers[x].SetWeatherModifier(weather.weatherType);
            }
        }
        public void SetCustomerTemeratureModifiers()
        {
            for (int x = 0; x < numberOfCustomers; x++)
            {
                customers[x].SetTemperatureModifier(weather.temperature, weather.minTemperature, weather.maxTemperature);
            }
        }

        public void SetCustomerActualPrice()
        {
            for (int x = 0; x < numberOfCustomers; x++)
            {
                customers[x].SetActualPrice();
            }
        }

        public void GenerateCustomers()
        {
            GetNumberOfCustomers();
            PopulateCustomers();
            SetCustomerMood();
            SetCustomerWeatherModifiers();
            SetCustomerTemeratureModifiers();
            SetCustomerActualPrice();
        }

        public void GoThroughDay(Player player1, Player player2, Store store)
        {
            
            player1.DisplayMoney();
            UserInterface.DisplayTodaysForecast(weather.forecast.GetForecastWeather(), weather.forecast.forecastTemperature);
            player1.SetPriceLemonade();
            Console.Clear();
            player2.DisplayMoney();
            UserInterface.DisplayTodaysForecast(weather.forecast.GetForecastWeather(), weather.forecast.forecastTemperature);
            player2.SetPriceLemonade();
            Console.Clear();
            player1.BuyIngredients(store.priceCups, store.priceIce, store.priceLemons, store.priceSugar);
            player1.StoreNumberCups();
            Console.Clear();
            player2.BuyIngredients(store.priceCups, store.priceIce, store.priceLemons, store.priceSugar);
            player2.StoreNumberCups();
            player1.SaveMoneyBeforeDay();
            player2.SaveMoneyBeforeDay();
            RunStandForDay(player1);
            RunStandForDay(player2);
            
            
        }
        public void RunStandForDay(Player player)
        {
            foreach (Customer customer in customers)
            {
                if (customer.actualPriceWillingToPay >= player.stand.priceLemonade*100 && player.stand.inventory.cups.Count() > 0)
                {
                    if (player.stand.inventory.cupsOfLemonadeLeftInPitcher > 0)
                    {
                        player.stand.SellLemonade();
                    }
                    else if (player.stand.inventory.sugarCups.Count() >= player.stand.recipe.requiredCupsOfSugar && player.stand.inventory.lemons.Count() >= player.stand.recipe.requiredLemons && player.stand.inventory.iceCubes.Count() >= player.stand.recipe.requiredIceCubes)
                    {
                        player.stand.MakeLemonade();
                        player.stand.SellLemonade();
                    }
                }
            }

        }

    }
}
