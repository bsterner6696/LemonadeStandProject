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
        string name;


        public void SetName(string name)
        {
            ///set user name
            name = Console.ReadLine();
        }
         
    }
}
