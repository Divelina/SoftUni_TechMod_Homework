using System;

namespace _01_ChooseDrink
{
    public class ChooseDrink
    {
        public static void Main()
        {
            var profession = Console.ReadLine();
            var drink = string.Empty;

            switch (profession)
            {
                case "Athlete":
                    drink = "Water"; break;
                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee"; break;
                case "SoftUni Student":
                    drink = "Beer"; break;
                default:
                    drink = "Tea"; break;
            }

            Console.WriteLine($"{drink}");
        }
    }
}
