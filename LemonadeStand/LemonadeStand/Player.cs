using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    abstract public class Player
    {
        Inventory inventory;
        Store store;
        Stand stand;
        string name;


        public void SetName(string name)
        {
            ///set user name
            name = Console.ReadLine();
        }

        public void BuyIce(int amount)
        {
            inventory.money -= (amount * store.priceIce);
            inventory.cubesIce += amount;
            for (int x = 0; x < amount; x++)
            {
                inventory.iceCubes.Add(new Ice());
            }
        }
        public void BuyLemons(int amount)
        {
            inventory.money -= (amount * store.priceLemons);
            inventory.numberLemons += amount;
            for (int x = 0; x < amount; x++)
            {
                inventory.lemons.Add(new Lemon());
            }
        }

        public void BuySugar(int amount)
        {
            inventory.money -= (amount * store.priceSugar);
            inventory.cupsSugar += amount;
            for (int x = 0; x < amount; x++)
            {
                inventory.sugarCups.Add(new Sugar());
            }
        }

        public void BuyCups(int amount)
        {
            inventory.money -= (amount * store.priceCups);
            inventory.numberCups += amount;
            for (int x = 0; x < amount; x++)
            {
                inventory.cups.Add(new Cup());
            }
        }
    }
}
