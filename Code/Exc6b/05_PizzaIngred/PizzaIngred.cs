using System;
using System.Linq;

namespace _05_PizzaIngred
{
   public class PizzaIngred
    {
        public static void Main()
        {
            var allIngredients = Console.ReadLine()
                  .Split(' ')
                  .ToArray();

            var ingrdLength = int.Parse(Console.ReadLine());

            var output = new string[10];
            var countIngrd = 0;
            var result = string.Empty;

            for (int i = 0; i < allIngredients.Length; i++)
            {
                if (allIngredients[i].Length == ingrdLength)
                {
                    output[countIngrd] = allIngredients[i];
                    countIngrd++;
                    result += allIngredients[i] + ", ";
                    Console.WriteLine($"Adding {allIngredients[i]}.");             
                }

                if (countIngrd == 10)
                {
                    break;
                }
            }

            result = result.Trim().Trim(',');

            Console.WriteLine($"Made pizza with total of {countIngrd} ingredients.");
            Console.WriteLine($"The ingredients are: {result}.");
        }
    }
}
