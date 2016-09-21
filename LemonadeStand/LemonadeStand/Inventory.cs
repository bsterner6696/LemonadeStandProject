using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {

        public int cupsOfLemonadeLeftInPitcher;
        public double money;
        public Inventory()
        {

            cupsOfLemonadeLeftInPitcher = 0;
            money = 20.00;
        }
        public List<Lemon> lemons = new List<Lemon>();
        public List<Cup> cups = new List<Cup>();
        public List<Sugar> sugarCups = new List<Sugar>();
        public List<Ice> iceCubes = new List<Ice>();
                
    }
}


