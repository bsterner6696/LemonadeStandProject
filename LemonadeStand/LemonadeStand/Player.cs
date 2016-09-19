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
        double money;
        string name;

        public string GetName()
        {
            ///prompt for user name
        }

        public void SetName(string name)
        {
            ///set user name
        }
         
    }
}
