using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public int dayNumber;
        List<Customer> customer;
        Weather weather = new Weather();
        Random random = new Random();
        
        public int GetNumberOfCustomers()
        {
            return random.Next(70, 121);
        }



    }
}
