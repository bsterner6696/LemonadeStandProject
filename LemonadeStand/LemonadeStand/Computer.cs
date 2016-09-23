using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Computer : Player
    {
        public int minPrice = 10;
        public int maxPrice = 32;
        public int cupsToHaveEachDay = 100;
        public int iceToHaveEachDay = 200;
        public int lemonsToHaveEachDay = 40;
        public int sugarToHaveEachDay = 40;

        public Computer()
        {
            name = "the computer";
        }

        public override void SetPriceLemonade()
        {
            stand.priceLemonade = random.Next(minPrice, maxPrice+1)*.01;
            Console.WriteLine("{0} sets its price at ${1}", name, string.Format("{0:0.00}", Math.Round(stand.priceLemonade, 2)));
            Console.ReadLine();
        }

        public override void ShopForCups(double priceCups)
        {
            int amount = cupsToHaveEachDay - stand.inventory.cups.Count();
            if (amount > 0)
            {
                if (amount * priceCups <= stand.inventory.money)
                {

                    BuyCups(amount, priceCups);
                }
            }
        }
        public override void ShopForIce(double priceIce)
        {
            int amount = iceToHaveEachDay - stand.inventory.iceCubes.Count();
            if (amount > 0)
            {
                if (amount * priceIce <= stand.inventory.money)
                {

                    BuyIce(amount, priceIce);
                }
                
            }
        }
        public override void ShopForLemons(double priceLemons)
        {
            int amount = lemonsToHaveEachDay - stand.inventory.lemons.Count();
            if (amount > 0)
            {
                if (amount * priceLemons <= stand.inventory.money)
                {

                    BuyLemons(amount, priceLemons);
                }

            }
        }
        public override void ShopForSugar(double priceSugar)
        {
            int amount = sugarToHaveEachDay - stand.inventory.sugarCups.Count();
            if (amount > 0)
            {
                if (amount * priceSugar <= stand.inventory.money)
                {

                    BuySugar(amount, priceSugar);
                }

            }
        }

        public override void BuyIngredients(double priceCups, double priceIce, double priceLemons, double priceSugar)
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
    }
}
