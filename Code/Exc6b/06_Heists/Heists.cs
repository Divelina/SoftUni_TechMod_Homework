using System;
using System.Linq;

namespace _06_Heists
{
    public class Heists
    {
        public static void Main()
        {
            var prices = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var jewelPrice = prices[0];
            var goldPrice = prices[1];

            var jewels = 0;
            var gold = 0;
            var expenses = 0L;

            var loot = Console.ReadLine();

            while (loot != "Jail Time")
            {
                var splitLoot = loot.Split(' ').ToArray();

                expenses += long.Parse(splitLoot[1]);

                for (int i = 0; i < splitLoot[0].Length; i++)
                {
                    if (splitLoot[0][i] == '%')
                    {
                        jewels++;
                    }
                    else if (splitLoot[0][i] == '$')
                    {
                        gold++;
                    }
                }

                loot = Console.ReadLine();
            }

            var earnings = (long)jewelPrice * jewels + (long)goldPrice * gold;
            var heist = earnings - expenses;

            if (heist >= 0)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {heist}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {-heist}.");
            }
        }
    }
}
