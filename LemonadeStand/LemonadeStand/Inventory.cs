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
        public int maxPitcherCapacity = 10;
        public double startingMoney = 20.00;
        public Inventory()
        {

            cupsOfLemonadeLeftInPitcher = 0;
            money = startingMoney;
        }
        public List<Lemon> lemons = new List<Lemon>();
        public List<Cup> cups = new List<Cup>();
        public List<Sugar> sugarCups = new List<Sugar>();
        public List<Ice> iceCubes = new List<Ice>();
                
    }
}


