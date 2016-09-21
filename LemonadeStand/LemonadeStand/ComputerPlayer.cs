using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class ComputerPlayer : Player
    {
        public int minPrice = 10;
        public int maxPrice = 32;

        public ComputerPlayer()
        {
            name = "the computer";
        }

        public override void SetPriceLemonade()
        {
            stand.priceLemonade = random.Next(minPrice, maxPrice);
            Console.WriteLine("{0} sets its price at {1} cents.", name, stand.priceLemonade);
            Console.ReadLine();
        }

        public override void ShopForCups(double priceCups)
        {
            int amount = 100 - stand.inventory.cups.Count();
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
            int amount = 200 - stand.inventory.iceCubes.Count();
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
            int amount = 40 - stand.inventory.lemons.Count();
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
            int amount = 40 - stand.inventory.sugarCups.Count();
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
