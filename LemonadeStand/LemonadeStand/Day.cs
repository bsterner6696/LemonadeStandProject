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
        public List<Customer> customers = new List<Customer>();
        public Weather weather = new Weather();
        Random random = new Random();
        public int numberOfCustomers;
        public Day()
        {
            numberOfCustomers = 70;
        }
        
        public void GetNumberOfCustomers()
        {
            numberOfCustomers = random.Next(70, 121);
        }

        public void PopulateCustomers()
        {
            for (int x = 0; x < numberOfCustomers; x++)
            {
                customers.Add(new Customer());
            }
        }

        public void SetCustomerBasePrice()
        {
            for (int x = 0; x < numberOfCustomers; x++)
            {
                customers[x].SetBasePrice();
            }
        }
        
        public void SetCustomerWeatherModifiers()
        {
            for (int x = 0; x < numberOfCustomers; x++)
            {
                customers[x].SetWeatherModifier(weather.weatherType);
            }
        }
        public void SetCustomerTemeratureModifiers()
        {
            for (int x = 0; x < numberOfCustomers; x++)
            {
                customers[x].SetTemperatureModifier(weather.temperature);
            }
        }

        public void SetCustomerActualPrice()
        {
            for (int x = 0; x < numberOfCustomers; x++)
            {
                customers[x].SetActualPrice();
            }
        }

        public void GenerateCustomers()
        {
            GetNumberOfCustomers();
            PopulateCustomers();
            SetCustomerBasePrice();
            SetCustomerWeatherModifiers();
            SetCustomerTemeratureModifiers();
            SetCustomerActualPrice();
        }

    }
}
