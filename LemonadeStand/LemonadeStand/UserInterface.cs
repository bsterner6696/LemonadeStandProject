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

        public void DisplayForecast()
        {

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
        
        public void DisplayMoney(double money)
        {
            Console.WriteLine("You have ${0}", money);
        }
    }
}
