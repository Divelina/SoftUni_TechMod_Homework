using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_HandsOfCards
{
    public class HandsOfCards
    {
        public static void Main()
        {
            var personCards = new Dictionary<string, HashSet<string>>();
            var line = Console.ReadLine();

            while (line != "JOKER")
            {
                var split = line.Split(':').ToArray();

                var name = split[0];
                var cards = split[1]
                    .Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                if (!personCards.ContainsKey(name))
                {
                    personCards[name] = new HashSet<string>();
                }

                for (int i = 0; i < cards.Count; i++)
                {
                    personCards[name].Add(cards[i]);
                }

                line = Console.ReadLine();
            }

            foreach (var person in personCards)
            {
                var sum = 0;

                foreach (var card in person.Value)
                {
                    var cardValue = DetermineValue(card);
                    sum += cardValue;
                }

                Console.WriteLine($"{person.Key}: {sum}");
            }

        }

        public static int DetermineValue(string str)
        {
            var powerValue = new Dictionary<string, int>
            {
                {"1", 1}, {"2", 2 }, {"3", 3 }, {"4", 4 }, {"5", 5 },
                {"6", 6}, {"7", 7 }, {"8", 8 }, {"9", 9 }, {"10", 10 },
                {"J", 11}, {"Q", 12 }, {"K", 13 }, {"A", 14 }
            };

            var typeValue = new Dictionary<string, int>
            {
                {"S", 4 }, {"H", 3 }, {"D", 2 }, {"C", 1 }
            };

            var type = str[str.Length - 1].ToString();
            var power = string.Empty;
            if (str.Length == 3)
            {
                power = "10";
            }
            else if (str.Length == 2)
            {
                power = str[0].ToString();
            }

            var value = powerValue[power] * typeValue[type];

            return value;
        }

    }
}