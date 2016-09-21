using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    static public class UserInterface
    {
        

        public static void PromptForName(string name)
        {
            Console.WriteLine("Please enter name for {0}.", name);
        }

        
        public static void DisplayForecast(int type, int temperature, int dayNumber)
        {
            string weatherType;
            switch (type)
            {
                case 0:
                    weatherType = "Sunny and Clear";
                    break;

                case 1:
                    weatherType = "Rainy";
                    break;

                case 2:
                    weatherType = "Cloudy";
                    break;

                case 3:
                    weatherType = "Hazy";
                    break;

                default:
                    weatherType = "Sunny and Clear";
                    break;

            }

            Console.WriteLine("The weather for day number {0} will be {1} and {2} degrees.", dayNumber, weatherType, temperature);
        }

        public static void AnnounceForecast()
        {
            Console.WriteLine("Now it is time for the forecast for the next seven days.");
        }
        


        public static void DisplayInventory(int number, string itemName, string name)
        {
            Console.WriteLine("{0}, you have {1} {2}.",name, number, itemName);
        }

        public static void PromptToBuy(string itemName)
        {
            Console.WriteLine("How many {0} would you like to buy?", itemName);
        }

        public static void DisplayPricePer(double price)
        {
            Console.WriteLine("They cost ${0} each.", price);
        }
        
        public static void DisplayMoney(string money, string name)
        {
            Console.WriteLine("{0}, you have ${1}",name, money);
        }
        public static void DisplayWeather(string weather, int temperature)
        {
            Console.WriteLine("The weather today is {0} with a temperature of {1}", weather, temperature);
        }
        public static void RequestLemonadePrice()
        {
            Console.WriteLine("How many cents would you like to charge for a glass of lemonade?");
        }

        public static void AnnounceEndOfDay(int dayNumber)
        {
            Console.WriteLine("Completed day number {0}!", dayNumber);
        }

        public static void DisplayCupsSold(int number, string name, int total)
        {
            Console.WriteLine("{0}: {1} cups of lemonade sold today out of a possible {2}.", name, number, total);
        }
        public static void DisplayIceMelted()
        {
            Console.WriteLine("Your ice has melted!");
        }

        public static void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
            Console.WriteLine("In this game you will buy ingredients to make lemonade, and run a stand to sell it.");
            Console.WriteLine("The weather on a particular day will determine how much a customer will pay for lemonade.");
            Console.WriteLine("Even in the best case scenario, a customer will never pay more than 40 cents for a cup.");
            Console.WriteLine("A pitcher holds 10 cups of lemonade.");
            Console.WriteLine("A pitcher of lemonade requires 4 lemons, 4 cups of sugar, and 20 ice cubes to make.");
            Console.WriteLine("Good luck!");
        }

        public static void RequestName(string name)
        {
            Console.WriteLine("Enter name for {0}.", name);
        }

        public static void ListGameModeOptions()
        {
            Console.WriteLine("Enter 'alone' to play on your own.");
            Console.WriteLine("Enter 'computer' to play vs computer.");
            Console.WriteLine("Enter '2' to play with 2 players.");
        }

        public static void PromptTotalDays()
        {
            Console.WriteLine("Please enter the desired number of in game days to play.");
            Console.WriteLine("Enter a number between 1 and 28.");
        }
    }
}
