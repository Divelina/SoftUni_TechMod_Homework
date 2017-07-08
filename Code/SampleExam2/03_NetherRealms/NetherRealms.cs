using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03_NetherRealms
{
    public class Deamons
    {
        public string Name { get; set; }
        public long Health { get; set; }
        public decimal Damage { get; set; }
    }

    public class NetherRealms
    {
        public static void Main()
        {
            var deamons = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t'}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var deamonList = new List<Deamons>();

            var pattern1 = @"[+-]?(\d+\.\d+|\d+)";
            var numsRegex = new Regex(pattern1);

            var healthPattern = @"[^\d\-*\/\.]";
            var healthRegex = new Regex(healthPattern);

            foreach (var deamonName in deamons)
            {
                MatchCollection healths = healthRegex.Matches(deamonName);
                var changedName = deamonName;
                var damage = 0.0m;
                var health = 0L;

                foreach (Match ch in healths)
                {
                    health += (long)char.Parse(ch.ToString());
                }

                MatchCollection numbers = numsRegex.Matches(deamonName);
                
                foreach (Match num in numbers)
                {
                    damage += decimal.Parse(num.ToString());
                }

                foreach (var letter in deamonName)
                {
                    if (letter == '*')
                    {
                        damage *= 2;
                    }
                    else if (letter == '/')
                    {
                        damage = damage / 2.0m;
                    }
                }
                
                var theDeamon = CreateNewDeamon(deamonName, damage, health);

                deamonList.Add(theDeamon);
            }

            deamonList = deamonList.OrderBy(d => d.Name).ToList();

            foreach (var deamon in deamonList)
            {
                Console.WriteLine($"{deamon.Name} - {deamon.Health} health, {deamon.Damage:F2} damage");
            }
        }

        public static Deamons CreateNewDeamon(string deamonName, decimal damage, long health)
        {
            var newDeamon = new Deamons
            {
                Name = deamonName,
                Damage = damage,
                Health = health
            };

            return newDeamon;
        }
    }
}
