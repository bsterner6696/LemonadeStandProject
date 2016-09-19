using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        int numberCups;
        int numberLemons;
        int cupsSugar;
        int cubesIce;
        int CupsOfLemonadeLeftInPitcher;
        double money;
        List<Lemon> lemons;
        List<Cup> cups;
        List<Sugar> sugarCups;
        List<Ice> iceCubes;

        public void MakeLemonade()
        {
            numberLemons -= 4;
            cupsSugar -= 4;
            cubesIce -= 20;
            CupsOfLemonadeLeftInPitcher = 10;
            for (int x = 0; x < 4; x++)
            {
                lemons.RemoveAt(0);
                sugarCups.RemoveAt(0);
                for (int y = 0; y < 5; y++)
                {
                    iceCubes.RemoveAt(0);
                }
            }
        }

    }
}
