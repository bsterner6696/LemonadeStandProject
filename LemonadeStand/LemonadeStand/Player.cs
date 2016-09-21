using System;
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

        public void SetName(string name)
        {
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
    }
}
