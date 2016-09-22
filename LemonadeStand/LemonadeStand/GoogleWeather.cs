using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LemonadeStand
{
    class GoogleWeather
    {
        public static List<GoogleWeatherCondition> GetForecast(string location)
        {
            List<GoogleWeatherCondition> googleWeatherConditions = new List<GoogleWeatherCondition>();

            XmlDocument xmlWeatherCondition = new XmlDocument();
            xmlWeatherCondition.Load(string.Format("http://www.google.com/ig/api?weather={0}", location));

            if (xmlWeatherCondition.SelectSingleNode("xml_api_reply/weather/problem_cause") != null)
            {
                googleWeatherConditions = null;
            }
            else
            {
                foreach (XmlNode node in xmlWeatherCondition.SelectNodes("/xml_api_reply/weather/forecast_conditions"))
                {
                    GoogleWeatherCondition googleWeatherCondition = new GoogleWeatherCondition();
                    googleWeatherCondition.City = xmlWeatherCondition.SelectSingleNode("/xml_api_reply/weather/forecast_information/city").Attributes["data"].InnerText;
                    googleWeatherCondition.Condition = node.SelectSingleNode("condition").Attributes["data"].InnerText;
                    googleWeatherCondition.High = node.SelectSingleNode("high").Attributes["data"].InnerText;
                    googleWeatherConditions.Add(googleWeatherCondition);
                }
            }

            return googleWeatherConditions;

        }
    }
}
