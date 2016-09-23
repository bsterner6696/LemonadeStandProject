using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        public int basePriceWillingToPay = 20;
        public int moodModifier;
        public int moodModifierMax = 20;
        public int moodModifierMin = 0;
        public int weatherModifier;
        public int weatherModifierBaseMultiplier = 1;
        public int sunnyMultiplier = 3;
        public int rainyMultiplier = 10;
        public int cloudyMultiplier = 6;
        public int hazyMultiplier = 0;
        public int temperatureModifier;
        public int actualPriceWillingToPay;
        public int maxTemperatureModifier = 10;
        static Random random = new Random();
        public Customer()
        {

        }
        public int GetMaxPriceWillingToPay()
        {
            return (moodModifierMax + weatherModifierBaseMultiplier * rainyMultiplier + maxTemperatureModifier);
        }
        
        
        public void SetMoodModifier()
        {
            moodModifier = random.Next(moodModifierMin, moodModifierMax + 1);
        }

        public void SetActualPrice()
        {
            actualPriceWillingToPay = basePriceWillingToPay + moodModifier - weatherModifier - temperatureModifier;
        }

        public void SetWeatherModifier(int weather)
        {
            switch (weather)
            {
                case 0:
                    weatherModifier = sunnyMultiplier * weatherModifierBaseMultiplier; 
                    break;

                case 1:

                    weatherModifier = rainyMultiplier * weatherModifierBaseMultiplier;
                    break;

                case 2:
                    weatherModifier = cloudyMultiplier * weatherModifierBaseMultiplier;
                    break;

                case 3:
                    weatherModifier = hazyMultiplier * weatherModifierBaseMultiplier;
                    break;

                default:
                    weatherModifier = sunnyMultiplier * weatherModifierBaseMultiplier;
                    break;
            }
        }

        public void SetTemperatureModifier(int temperature, int temperatureMin, int temperatureMax)
        {
            double unroundedNumber = maxTemperatureModifier - ((temperature - temperatureMin) / ((temperatureMax - temperatureMin)/maxTemperatureModifier));
            temperatureModifier = Convert.ToInt16(Math.Floor(unroundedNumber));
        }
    }
}
