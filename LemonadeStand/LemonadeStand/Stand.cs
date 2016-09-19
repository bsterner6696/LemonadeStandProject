using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Stand
    {
        Inventory inventory;

        public void SellLemonade(double price)
        {
            inventory.CupsOfLemonadeLeftInPitcher -= 1;
            inventory.money += price;
        }

        public void MakeLemonade()
        {
            inventory.numberLemons -= 4;
            inventory.cupsSugar -= 4;
            inventory.cubesIce -= 20;
            inventory.CupsOfLemonadeLeftInPitcher = 10;
            for (int x = 0; x < 4; x++)
            {
                inventory.lemons.RemoveAt(0);
                inventory.sugarCups.RemoveAt(0);
                for (int y = 0; y < 5; y++)
                {
                    inventory.iceCubes.RemoveAt(0);
                }
            }
        }
    }
}
