using System;

namespace ChooseDrink2
{
    public class ChooseDrink2
    {
        public static void Main()
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            //var drink = string.Empty;
            var price = 0.0;

            switch (profession)
            {
                case "Athlete":
                    {
                        //drink = "Water";
                        price = 0.7 * quantity;
                    }
                    break;
                case "Businessman":
                case "Businesswoman":
                    {
                        //drink = "Coffee";
                        price = 1.0 * quantity;
                    }
                    break;
                case "SoftUni Student":
                    {
                        //drink = "Beer";
                        price = 1.7 * quantity;
                    }
                    break;
                default:
                    {
                        //drink = "Tea";
                        price = 1.2 * quantity;
                    }
                    break;
            }

            Console.WriteLine($"The {profession} has to pay {price:F2}.");
        }
    }
}
