using System;
using System.Collections.Generic;

namespace _08_CaloriesCounter
{
    public class CaloriesCounter
    {
        public static void Main()
        {
            var ingredientsNum = int.Parse(Console.ReadLine());

            var caloriesTable = new Dictionary<string, int>
            {
                { "cheese", 500},
                { "tomato sauce", 150},
                { "salami", 600 },
                { "pepper", 50 }
            };

            var totalCalories = 0;

            for (int i = 1; i <= ingredientsNum; i++)
            {
                var currentIngredient = Console.ReadLine().ToLower();
                if (caloriesTable.ContainsKey(currentIngredient))
                {
                    totalCalories += caloriesTable[currentIngredient];
                }
            }

            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
