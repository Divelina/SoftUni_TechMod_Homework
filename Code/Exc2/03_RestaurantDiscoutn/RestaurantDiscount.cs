using System;

namespace _03_RestaurantDiscoutn
{
    public class RestaurantDiscount
    {
        public static void Main()
        {
            var personNum = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();

            var price = 0.0;
            var hallType = string.Empty;
            var areTooMany = false;
            var pricePerPerson = 0.0;

            if ((personNum > 0) && (personNum <= 50))
            {
                price += 2500;
                hallType = "Small Hall";
            }
            else if (personNum <= 100)
            {
                price += 5000;
                hallType = "Terrace";
            }
            else if (personNum <= 120)
            {
                price += 7500;
                hallType = "Great Hall";
            }
            else
            {
                areTooMany = true;
                Console.WriteLine("We do not have an appropriate hall.");
            }

            if (!areTooMany)
            {
                if (package == "Normal")
                {
                    price += 500;
                    price *= 0.95;
                }
                else if (package == "Gold")
                {
                    price += 750;
                    price *= 0.9;
                }
                else if (package == "Platinum")
                {
                    price += 1000;
                    price *= 0.85;
                }

                pricePerPerson = price / personNum;

                Console.WriteLine($"We can offer you the {hallType}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
        }
    }
}
