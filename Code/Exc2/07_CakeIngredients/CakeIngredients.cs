using System;

namespace _07_CakeIngredients
{
    public class CakeIngredients
    {
        public static void Main()
        {
            var nextIngredient = Console.ReadLine();
            var countIngredients = 0;

            while (nextIngredient != "Bake!")
            {
                countIngredients++;
                Console.WriteLine($"Adding ingredient {nextIngredient}.");
                nextIngredient = Console.ReadLine();
            }

            Console.WriteLine($"Preparing cake with {countIngredients} ingredients.");
        }
    }
}
