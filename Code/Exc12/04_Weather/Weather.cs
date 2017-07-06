using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04_Weather
{
    public class theWeather
    {
        public double Temperature { get; set; }
        public string Conditions { get; set; }
    }

    public class Weather
    {
        public static void Main()
        {
            var cityWeather = new Dictionary<string, theWeather>();

            var pattern = @"([A-Z]{2})([0-9]{0,2}\.[0-9]{0,2})([a-zA-z]+)\|";

            var inputLine = Console.ReadLine();
            var forecastRegex = new Regex(pattern);


            while (inputLine != "end")
            {
                var isValid = forecastRegex.IsMatch(inputLine);

                if (isValid)
                {
                    var forecastMatch = forecastRegex.Match(inputLine);
                    var city = forecastMatch.Groups[1].ToString();
                    var temperature = double.Parse(forecastMatch.Groups[2].ToString());
                    var condition = forecastMatch.Groups[3].ToString();

                    if (!cityWeather.ContainsKey(city))
                    {
                        var weather = CreateWeatherObject(temperature, condition);
                        cityWeather[city] = weather;
                    }
                    else
                    {
                        cityWeather[city].Temperature = temperature;
                        cityWeather[city].Conditions = condition;
                    }
                }

                inputLine = Console.ReadLine();
            }

            cityWeather = cityWeather
                .OrderBy(c => c.Value.Temperature)
                .ToDictionary(c => c.Key, c => c.Value);

            foreach (var city in cityWeather)
            {
                Console.WriteLine($"{city.Key} => {city.Value.Temperature:F2} => {city.Value.Conditions}");
            }
        }

        public static theWeather CreateWeatherObject(double temperature, string condition)
        {
            var currentWeather = new theWeather
            {
                Temperature = temperature,
                Conditions = condition
            };

            return currentWeather;
        }
    }
}
