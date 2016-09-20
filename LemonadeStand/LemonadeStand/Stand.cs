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
        public int priceLemonade;
        public Recipe recipe = new Recipe();

        public void SellLemonade()
        {
            inventory.cupsOfLemonadeLeftInPitcher -= 1;
            inventory.numberCups -= 1;
            inventory.cups.RemoveAt(0);
            double aPenny = .01;
            inventory.money += priceLemonade * aPenny;
        }

        public void MakeLemonade()
        {
            inventory.numberLemons -= recipe.requiredLemons;
            inventory.cupsSugar -= recipe.requiredCupsOfSugar;
            inventory.cubesIce -= recipe.requiredIceCubes;
            inventory.cupsOfLemonadeLeftInPitcher = 10;
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
