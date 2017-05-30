using System;

namespace _06_TheatrePromotions
{
    public class TheatrePromotions
    {
        public static void Main()
        {
            var day = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var price = 0;
            var isAgeValid = true;

            if ((age >=0) && (age <= 18))
            {
                if (day == "Weekday")
                {
                    price = 12;
                }
                else if (day == "Weekend")
                {
                    price = 15;
                }
                else
                {
                    price = 5;
                }
            }
            else if ((age>18) && (age <= 64))
            {
                if (day == "Weekday")
                {
                    price = 18;
                }
                else if (day == "Weekend")
                {
                    price = 20;
                }
                else
                {
                    price = 12;
                }
            }
            else if ((age>64) && (age <= 122))
            {
                if (day == "Weekday")
                {
                    price = 12;
                }
                else if (day == "Weekend")
                {
                    price = 15;
                }
                else
                {
                    price = 10;
                }
            }
            else
            {
                Console.WriteLine($"Error!");
                isAgeValid = false;
            }

            if (isAgeValid)
            {
                Console.WriteLine($"{price}$");
            }
        }
    }
}
