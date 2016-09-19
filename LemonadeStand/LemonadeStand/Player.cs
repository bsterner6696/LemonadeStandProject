using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    abstract public class Player
    {
        
        public Store store;
        public Stand stand;
        public string name;


        public void SetName(string name)
        {
            name = Console.ReadLine();
        }

        public void BuyIce(int amount)
        {
            stand.inventory.money -= (amount * store.priceIce);
            stand.inventory.cubesIce += amount;
            for (int x = 0; x < amount; x++)
            {
                stand.inventory.iceCubes.Add(new Ice());
            }
        }
        public void BuyLemons(int amount)
        {
            stand.inventory.money -= (amount * store.priceLemons);
            stand.inventory.numberLemons += amount;
            for (int x = 0; x < amount; x++)
            {
                stand.inventory.lemons.Add(new Lemon());
            }
        }

        public void BuySugar(int amount)
        {
            stand.inventory.money -= (amount * store.priceSugar);
            stand.inventory.cupsSugar += amount;
            for (int x = 0; x < amount; x++)
            {
                stand.inventory.sugarCups.Add(new Sugar());
            }
        }

        public void BuyCups(int amount)
        {
            stand.inventory.money -= (amount * store.priceCups);
            stand.inventory.numberCups += amount;
            for (int x = 0; x < amount; x++)
            {
                stand.inventory.cups.Add(new Cup());
            }
        }
    }
}
