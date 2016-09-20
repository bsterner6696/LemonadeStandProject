using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        public int basePriceWillingToPay;
        public int weatherModifier;
        public int temperatureModifier;
        public int actualPriceWillingToPay;
        Random random = new Random();
        public Customer()
        {

        }

        public void SetBasePrice()
        {
            basePriceWillingToPay = 20 + random.Next(0, 21);
        }

        public void SetActualPrice()
        {
            actualPriceWillingToPay = basePriceWillingToPay - weatherModifier - temperatureModifier;
        }

        public void SetWeatherModifier(int weather)
        {
            switch (weather)
            {
                case 0:
                    weatherModifier = 3;
                    break;

                case 1:

                    weatherModifier = 10;
                    break;

                case 2:
                    weatherModifier = 6;
                    break;

                case 3:
                    weatherModifier = 0;
                    break;

                default:
                    weatherModifier = 3;
                    break;
            }
        }

        public void SetTemperatureModifier(int temperature)
        {
            double unroundedNumber = ((temperature - 60) / 4);
            temperatureModifier = Convert.ToInt16(Math.Floor(unroundedNumber));
        }
    }
}
