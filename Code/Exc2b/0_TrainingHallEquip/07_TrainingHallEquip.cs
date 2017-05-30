using System;

namespace _07_TrainingHallEquip
{
    public class TrainingHallEquip
    {
        public static void Main()
        {
            var budget = double.Parse(Console.ReadLine());
            var itemNum = int.Parse(Console.ReadLine());
            var spent = 0.0;

            var currentItemName = string.Empty;
            var currentItemPrice = 0.0;
            var currentItemQuant = 0;

            for (int i = 1; i <= itemNum; i++)
            {
                currentItemName = Console.ReadLine();
                currentItemPrice = double.Parse(Console.ReadLine());
                currentItemQuant = int.Parse(Console.ReadLine());

                if (currentItemQuant > 1)
                {
                    currentItemName += "s";
                }

                spent += currentItemPrice * currentItemQuant;

                Console.WriteLine($"Adding {currentItemQuant} {currentItemName} to cart.");
            }

            Console.WriteLine($"Subtotal: ${spent:F2}");

            if (budget >= spent)
            {
                Console.WriteLine($"Money left: ${(budget - spent):F2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${(spent - budget):F2} more.");
            }
        }
    }
}

