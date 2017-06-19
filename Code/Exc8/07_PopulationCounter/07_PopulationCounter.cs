using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_PopulationCounter
{
    public class Program
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var countryCityPop = new Dictionary<string, Dictionary<string, long>>();
            var output = new Dictionary<string, long>();

            while (line != "report")
            {
                var split = line.Split('|').ToArray();
                var city = split[0];
                var country = split[1];
                var population = long.Parse(split[2]);

                if (!countryCityPop.ContainsKey(country))
                {
                    countryCityPop[country] = new Dictionary<string, long>();
                }

                countryCityPop[country][city] = population;

                line = Console.ReadLine();
            }

            countryCityPop = countryCityPop
                .OrderByDescending(c => c.Value.Values.Sum())
                .ToDictionary(v => v.Key, 
                    v => v.Value
                    .OrderByDescending(c => c.Value)
                    .ToDictionary(c => c.Key, c => c.Value));

            foreach (var entry in countryCityPop)
            {
                Console.WriteLine($"{entry.Key} (total population: {entry.Value.Values.Sum()})");

                foreach (var city in entry.Value)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
