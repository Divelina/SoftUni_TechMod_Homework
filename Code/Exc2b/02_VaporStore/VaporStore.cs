using System;
using System.Collections.Generic;

namespace _02_VaporStore
{
    public class VaporStore
    {
        public static void Main()
        {
            var gamePrices = new Dictionary<string, double>
            {
                { "OutFall 4", 39.99 },
                { "CS: OG", 15.99 },
                { "Zplinter Zell", 19.99 },
                { "Honored 2", 59.99 },
                { "RoverWatch", 29.99 },
                { "RoverWatch Origins Edition", 39.99 }
            };

            var cash = double.Parse(Console.ReadLine());
            var initialCash = cash;

            var gameName = Console.ReadLine();

            var isCashLeft = true;

            while (gameName != "Game Time")
            {
                if (!gamePrices.ContainsKey(gameName))
                {
                    Console.WriteLine("Not Found");
                }
                else if (cash < gamePrices[gameName])
                {
                    Console.WriteLine("Too Expensive");
                }
                else
                {
                    cash -= gamePrices[gameName];
                    Console.WriteLine($"Bought {gameName}");
                    if (cash == 0)
                    {
                        Console.WriteLine("Out of money!");
                        isCashLeft = false;
                        break;
                    }
                }

                gameName = Console.ReadLine();
            }

            if (isCashLeft == true)
            {
                Console.WriteLine($"Total spent: ${(initialCash - cash):F2}. Remaining: ${cash:F2}");
            }
        }
    }
}
