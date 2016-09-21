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
        Player[] players = new Player[2];

        Day[] days = new Day[35];
        Forecast forecast = new Forecast();
        Store store = new Store();
        int dayCount;
        
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
            players[0] = player1;
            players[1] = player2;

        }

        public void Initialize()
        {
            SetGameMode();
            player1.SetName();
            player2.SetName();
            GenerateDays();
            GenerateWeather();
            GenerateCustomersForWeek();
            UserInterface.DisplayWelcomeMessage();
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
        
        

        public int DetermineCheaperPrice()
        {
            if (player1.stand.priceLemonade <= player2.stand.priceLemonade)
            {
                return 0;
            }else
            {
                return 1;
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
                DisplayForecast();
                Console.ReadLine();
                Console.Clear();
                days[dayCount].GoThroughDay(player1, player2, store);
                UserInterface.AnnounceEndOfDay(dayCount + 1);
                player1.DisplayCupsSold(days[dayCount].numberOfCustomers);
                player1.DisplayMoney();
                player2.DisplayCupsSold(days[dayCount].numberOfCustomers);
                player2.DisplayMoney();
                player1.ResetInventory();
                player2.ResetInventory();
                Console.ReadLine();
                Console.Clear();
                AdvanceDay();
            }
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
