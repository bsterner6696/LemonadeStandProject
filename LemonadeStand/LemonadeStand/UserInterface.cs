﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class UserInterface
    {
        int numberValue;

        public void PromptForName(string name)
        {
            Console.WriteLine("Please enter name for {0}.", name);
        }

        
        public void DisplayForecast(int type, int temperature, int dayNumber)
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

        public void AnnounceForecast()
        {
            Console.WriteLine("Now it is time for the forecast for the next seven days.");
        }
        public void SetNumberValue()
        {
            string amount = Console.ReadLine();
            int amt;
            if (Int32.TryParse(amount, out amt))
            {
                numberValue = amt;
            } else
            {
                Console.WriteLine("Enter a valid number.");
                SetNumberValue();
            }
        }
        public int GetNumberValue()
        {
            SetNumberValue();
            return numberValue;
        }

        public void DisplayInventory(int number, string itemName)
        {
            Console.WriteLine("You have {0} {1}.", number, itemName);
        }

        public void PromptToBuy(string itemName)
        {
            Console.WriteLine("How many {0} would you like to buy?", itemName);
        }

        public void DisplayPricePer(double price)
        {
            Console.WriteLine("They cost ${0} each.", price);
        }
        
        public void DisplayMoney(string money)
        {
            Console.WriteLine("You have ${0}", money);
        }
        public void DisplayWeather(string weather, int temperature)
        {
            Console.WriteLine("The weather today is {0} with a temperature of {1}", weather, temperature);
        }
        public void RequestLemonadePrice()
        {
            Console.WriteLine("How many cents would you like to charge for a glass of lemonade?");
        }

        public void AnnounceEndOfDay(int dayNumber)
        {
            Console.WriteLine("Completed day number {0}!", dayNumber);
        }

        public void DisplayCupsSold(int number)
        {
            Console.WriteLine("{0} cups of lemonade sold today.", number);
        }
        public void DisplayIceMelted()
        {
            Console.WriteLine("Your ice has melted!");
        }

        public void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
            Console.WriteLine("In this game you will buy ingredients to make lemonade, and run a stand to sell it.");
            Console.WriteLine("The weather on a particular day will determine how much a customer will pay for lemonade.");
            Console.WriteLine("Even in the best case scenario, a customer will never pay more than 40 cents for a cup.");
            Console.WriteLine("A pitcher holds 10 cups of lemonade.");
            Console.WriteLine("A pitcher of lemonade requires 4 lemons, 4 cups of sugar, and 20 ice cubes to make.");
            Console.WriteLine("Good luck!");
        }
    }
}
