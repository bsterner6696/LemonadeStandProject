using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;
using System.Reflection;

namespace LemonadeStand
{
    public class Game
    {
        Player player1;
        Player player2;
        Player[] players = new Player[2];
        public int totalDays;
        Day[] days = new Day[40];
        Forecast forecast = new Forecast();
        Store store = new Store();
        int dayCount;
        int maxNumberDays = 28;
        int minNumberDays = 7;
        FileReader fileReader = new FileReader();
        FileWriter fileWriter = new FileWriter();
        SoundPlayer bGMusic = new SoundPlayer("lemonadeSong.wav");
        Art art = new Art();
        int numberOfDaysInForecast = 7;

        
        public Game()
        {
            dayCount = 0;
        }

        public void GenerateDays()
        {
            for (int x = 0; x < (maxNumberDays+numberOfDaysInForecast); x++)
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
                    player1 = new Human("player 1");
                    player2 = new NoPlayer();
                    break;
                case "computer":
                    player1 = new Human("player 1");
                    player2 = new Computer();
                    break;
                case "2":
                    player1 = new Human("player 1");
                    player2 = new Human("player 2");
                    break;
                default:
                    Console.WriteLine("Enter valid option");
                    SetGameMode();
                    break;
            }
            players[0] = player1;
            players[1] = player2;

        }

        public void DetermineNumberOfDays()
        {
            UserInterface.PromptTotalDays(minNumberDays, maxNumberDays);
            
            string amt = Console.ReadLine();
            int amount;
            if (Int32.TryParse(amt, out amount))
            {
            }
            else
            {
                Console.WriteLine("Enter a valid number.");
                DetermineNumberOfDays();
            }
            if (amount <= maxNumberDays && amount >= minNumberDays)
            {
                totalDays = amount;
            } else
            {
                DetermineNumberOfDays();
            }
        }

        public void Initialize()
        {
            art.DrawTitleScreen();
            bGMusic.PlayLooping();
            Console.ReadLine();
            Console.Clear();
            DetermineNumberOfDays();
            SetGameMode();
            File.WriteAllText("dayLog.txt", String.Empty);
            Console.Clear();
            player1.SetName();
            player2.SetName();
            GenerateDays();
            GenerateWeather();
            GenerateCustomersForWeek();
            Console.Clear();
            UserInterface.DisplayWelcomeMessage(player1.stand.inventory.maxPitcherCapacity, player1.stand.recipe.requiredLemons, player1.stand.recipe.requiredCupsOfSugar, player1.stand.recipe.requiredIceCubes, days[0].customers[0].GetMaxPriceWillingToPay());
            Console.ReadLine();
            Console.Clear();
            LoopThroughDays();
            ReviewGameScores();
            Console.ReadLine();
        }

        public void SetWeatherForWeek()
        {
            for (int x = 0; x < maxNumberDays + numberOfDaysInForecast; x++)
            {
                days[x].weather.SetWeatherType();
            }
        }

        public void SetWeatherForecastForWeek()
        {
            for (int x = 0; x < maxNumberDays + numberOfDaysInForecast; x++)
            {
                days[x].weather.forecast.SetForecastWeather(days[x].weather.weatherType);
            }
        }

        public void SetTemperatureForecastForWeek()
        {
            for (int x = 0; x < maxNumberDays + numberOfDaysInForecast; x++)
            {
                days[x].weather.forecast.SetForecastTemperature(days[x].weather.temperature, days[x].weather.maxTemperature, days[x].weather.minTemperature);
            }
        }
        public void SetTemperatureForWeek()
        {
            for (int x = 0; x < maxNumberDays + numberOfDaysInForecast; x++)
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
            for (int x = 0; x < maxNumberDays + numberOfDaysInForecast; x++)
            {
                days[x].GenerateCustomers();
            }
        }
        
        
        public void AdvanceDay()
        {
            dayCount += 1;
        }

        public void LoopThroughDays()
        {
            while (dayCount < totalDays)
            {
                DisplayForecast();
                Console.ReadLine();
                Console.Clear();
                days[dayCount].GoThroughDay(player1, player2, store);
                UserInterface.AnnounceEndOfDay(dayCount + 1);
                UserInterface.DisplayActualWeather(days[dayCount].weather.GetWeather(), days[dayCount].weather.temperature);
                player1.DisplayCupsSold(days[dayCount].numberOfCustomers);
                player1.DisplayMoneyBeforeDay();
                player1.DisplayMoney();
                player2.DisplayCupsSold(days[dayCount].numberOfCustomers);
                player2.DisplayMoneyBeforeDay();
                player2.DisplayMoney();
                player1.ResetInventory();
                player2.ResetInventory();
                UserInterface.DisplayIceMelted();
                Console.ReadLine();
                Console.Clear();
                LogDaysEarnings();
                AdvanceDay();
            }
        }

        public void DisplayForecast()
        {
            UserInterface.AnnounceForecast();
            for (int x = dayCount; x < dayCount + numberOfDaysInForecast; x++)
            {
                UserInterface.DisplayForecast(days[x].weather.forecast.forecastWeather, days[x].weather.forecast.forecastTemperature, x + 1);
            }
        }

        public void LogDaysEarnings()
        {
            player1.LogEarnings(dayCount + 1);
            player2.LogEarnings(dayCount + 1);
        }

        public void ReviewGameScores()
        {
            Console.WriteLine("End of Game Statistics");
            Console.WriteLine(fileReader.ReadFile("dayLog.txt")); ;
        }
    }
}
