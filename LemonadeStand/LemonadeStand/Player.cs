﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    abstract public class Player
    {

        public Stand stand = new Stand();
        public string name;
        public int cupsBefore;
        static public Random random = new Random();

        public virtual void SetName()
        {
            UserInterface.RequestName(name);
            name = Console.ReadLine();
        }

        
        public void BuyIce(int amount, double price)
        {
            stand.inventory.money -= (amount * price);
            for (int x = 0; x < amount; x++)
            {
                stand.inventory.iceCubes.Add(new Ice());
            }
        }
        public void BuyLemons(int amount, double price)
        {
            stand.inventory.money -= (amount * price);
            for (int x = 0; x < amount; x++)
            {
                stand.inventory.lemons.Add(new Lemon());
            }
        }

        public void BuySugar(int amount, double price)
        {
            stand.inventory.money -= (amount * price);
            for (int x = 0; x < amount; x++)
            {
                stand.inventory.sugarCups.Add(new Sugar());
            }
        }

        public void BuyCups(int amount, double price)
        {
            stand.inventory.money -= (amount * price);
            for (int x = 0; x < amount; x++)
            {
                stand.inventory.cups.Add(new Cup());
            }
        }
        public virtual void SetPriceLemonade()
        {
            Console.WriteLine("How many cents would you like to charge for a glass of lemonade?");
            string price = Console.ReadLine();
            int prc;
            if (Int32.TryParse(price, out prc))
            {
                stand.priceLemonade = prc;

            }
            else
            {
                Console.WriteLine("Enter a valid number.");
                SetPriceLemonade();
            }
        }
        public virtual void ShopForCups(double priceCups)
        {

                UserInterface.DisplayInventory(stand.inventory.cups.Count(), "cups", name);
                UserInterface.PromptToBuy("cups");
                UserInterface.DisplayPricePer(priceCups);
                DisplayMoney();
                TryToBuyCups(priceCups);

        }

        public void TryToBuyCups(double priceCups)
        {
            string amt = Console.ReadLine();
            int amount;
            if (Int32.TryParse(amt, out amount))
            {
            }
            else
            {
                Console.WriteLine("Enter a valid number.");
                TryToBuyCups(priceCups);
            }
            if (amount * priceCups <= stand.inventory.money)
            {

                BuyCups(amount, priceCups);
            }
            else
            {
                TryToBuyCups(priceCups);
            }
        }

        public virtual void ShopForIce(double priceIce)
        {

                UserInterface.DisplayInventory(stand.inventory.iceCubes.Count(), "ice cubes", name);
                UserInterface.PromptToBuy("ice cubes");
                UserInterface.DisplayPricePer(priceIce);
                DisplayMoney();
                TryToBuyIce(priceIce);


        }

        public void TryToBuyIce(double priceIce)
        {
            string amt = Console.ReadLine();
            int amount;
            if (Int32.TryParse(amt, out amount))
            {
            }
            else
            {
                Console.WriteLine("Enter a valid number.");
                TryToBuyIce(priceIce);
            }
            if (amount * priceIce <= stand.inventory.money)
            {

                BuyIce(amount, priceIce);
            }
            else
            {
                TryToBuyIce(priceIce);
            }
        }

        public virtual void ShopForLemons(double priceLemons)
        {

                UserInterface.DisplayInventory(stand.inventory.lemons.Count(), "lemons", name);
                UserInterface.PromptToBuy("lemons");
                UserInterface.DisplayPricePer(priceLemons);
                DisplayMoney();
                TryToBuyLemons(priceLemons);

        }

        public void TryToBuyLemons(double priceLemons)
        {
            string amt = Console.ReadLine();
            int amount;
            if (Int32.TryParse(amt, out amount))
            {
            }
            else
            {
                Console.WriteLine("Enter a valid number.");
                TryToBuyLemons(priceLemons);
            }
            if (amount * priceLemons <= stand.inventory.money)
            {

                BuyLemons(amount, priceLemons);
            }
            else
            {
                TryToBuyLemons(priceLemons);
            }
        }
        public virtual void ShopForSugar(double priceSugar)
        {
                UserInterface.DisplayInventory(stand.inventory.sugarCups.Count(), "cups of sugar", name);
                UserInterface.PromptToBuy("cups of sugar");
                UserInterface.DisplayPricePer(priceSugar);
                DisplayMoney();
                TryToBuySugar(priceSugar);

        }

        public void TryToBuySugar(double sugarPrice)
        {
            string amt = Console.ReadLine();
            int amount;
            if (Int32.TryParse(amt, out amount))
            {
            }
            else
            {
                Console.WriteLine("Enter a valid number.");
                TryToBuySugar(sugarPrice);
            }
            if (amount * sugarPrice <= stand.inventory.money)
            {

                BuySugar(amount, sugarPrice);
            }
            else
            {
                TryToBuySugar(sugarPrice);
            }
        }

        public virtual void DisplayMoney()
        {
            UserInterface.DisplayMoney(string.Format("{0:0.00}", Math.Round(stand.inventory.money, 2)), name);
        }

        public virtual void BuyIngredients(double priceCups, double priceIce, double priceLemons, double priceSugar)
        {
            ShopForCups(priceCups);
            Console.Clear();
            ShopForIce(priceIce);
            Console.Clear();
            ShopForLemons(priceLemons);
            Console.Clear();
            ShopForSugar(priceSugar);
            Console.Clear();
        }
        public void StoreNumberCups()
        {
            cupsBefore = stand.inventory.cups.Count();
        }

        public virtual void DisplayCupsSold(int total)
        {
            UserInterface.DisplayCupsSold(cupsBefore - stand.inventory.cups.Count(), name, total);
        }
        public void ResetInventory()
        {
            stand.inventory.iceCubes.Clear();
            stand.inventory.cupsOfLemonadeLeftInPitcher = 0;
        }
    }
}
