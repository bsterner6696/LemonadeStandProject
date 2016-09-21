using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Game
    {
        Player player1;
        Player player2;
        Day[] days = new Day[35];
        Forecast forecast = new Forecast();
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

        public void SetGameMode()
        {
            UserInterface.ListGameModeOptions();
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "alone":
                    player1 = new HumanPlayer("player 1");
                    player2 = new NonePlayer();
                    break;
                case "computer":
                    player1 = new HumanPlayer("player 1");
                    player2 = new ComputerPlayer();
                    break;
                case "2":
                    player1 = new HumanPlayer("player 1");
                    player2 = new HumanPlayer("player 2");
                    break;
                default:
                    Console.WriteLine("Enter valid option");
                    SetGameMode();
                    break;
            }

        }

        public void Initialize()
        {
            GenerateDays();
            GenerateWeather();
            GenerateCustomersForWeek();
            UserInterface.DisplayWelcomeMessage();
            Console.ReadLine();
            Console.Clear();
            LoopThroughDays();
        }

        public void SetName(Player player)
        {
            UserInterface.RequestName(player);
            player.SetName();
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
                if (customer.actualPriceWillingToPay >= player1.stand.priceLemonade && player1.stand.inventory.cups.Count() > 0)
                {
                        if (player1.stand.inventory.cupsOfLemonadeLeftInPitcher > 0)
                        {
                            player1.stand.SellLemonade();
                        }
                        else if (player1.stand.inventory.sugarCups.Count() >= player1.stand.recipe.requiredCupsOfSugar && player1.stand.inventory.lemons.Count() >= player1.stand.recipe.requiredLemons && player1.stand.inventory.iceCubes.Count() >= player1.stand.recipe.requiredIceCubes)
                        {
                            player1.stand.MakeLemonade();
                            player1.stand.SellLemonade();
                        }
                }
            }
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
            player1.DisplayMoney(); 
            UserInterface.DisplayWeather(days[dayCount].weather.GetWeather(), days[dayCount].weather.temperature); 
            player1.SetPriceLemonade();
            Console.Clear();
            player1.BuyIngredients(store.priceCups, store.priceIce, store.priceLemons, store.priceSugar); 
            player1.StoreNumberCups();             
            RunStandForDay();
            UserInterface.AnnounceEndOfDay(dayCount + 1);
            player1.DisplayCupsSold();
            player1.DisplayMoney();
            AdvanceDay(); 
            player1.ResetInventory();
            UserInterface.DisplayIceMelted();   
            Console.ReadLine();
            Console.Clear();
        }

        public void DisplayForecast()
        {
            UserInterface.AnnounceForecast();
            for (int x = dayCount; x < dayCount + 7; x++)
            {
                UserInterface.DisplayForecast(days[x + 1].weather.forecast.forecastWeather, days[x + 1].weather.forecast.forecastTemperature, x + 2);
            }
        }


        
    }
}
