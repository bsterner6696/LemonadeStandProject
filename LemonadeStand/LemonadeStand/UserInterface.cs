using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class UserInterface
    {
        int numberValue;

        public void PromptForName(string name)
        {
            Console.WriteLine("Please enter name for {0}.", name);
        }

        public void DisplayForecast()
        {

        }
        public void SetNumberValue()
        {
            string amount = Console.ReadLine();
            int amt;
            if (Int32.TryParse(amount, out amt))
            {
                numberValue = amt;
            } else
            {
                Console.WriteLine("Enter a valid number.");
                SetNumberValue();
            }
        }
        public int GetNumberValue()
        {
            SetNumberValue();
            return numberValue;
        }


        
    }
}
