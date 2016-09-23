using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Stand
    {
        public Inventory inventory = new Inventory();
        public double priceLemonade;
        public Recipe recipe = new Recipe();
        public int CupsSoldPerTransaction = 1;
        

        public void SellLemonade()
        {
            inventory.cupsOfLemonadeLeftInPitcher -= CupsSoldPerTransaction;
            inventory.cups.RemoveAt(0);
            inventory.money += priceLemonade;
        }

        public void MakeLemonade()
        {
            inventory.cupsOfLemonadeLeftInPitcher = inventory.maxPitcherCapacity;
            for (int x = 0; x < recipe.requiredLemons; x++)
            {
                inventory.lemons.RemoveAt(0);
            }
            for (int x = 0; x < recipe.requiredCupsOfSugar; x++)
            {
                inventory.sugarCups.RemoveAt(0);
            }
            for (int x = 0; x < recipe.requiredIceCubes; x++)
            {
                inventory.iceCubes.RemoveAt(0);
            }
        }
    }
}
