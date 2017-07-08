using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace _01_CoffeeOrders
{
    public class CoffeeOrders
    {
        public static void Main()
        {
            var lineNum = int.Parse(Console.ReadLine());
            var totalPrice = 0.0m;

            for (int i = 1; i <= lineNum; i++)
            {
                var capsulePrice = decimal.Parse(Console.ReadLine());
                var date = DateTime
                    .ParseExact(Console.ReadLine(),"d/M/yyyy", CultureInfo.InvariantCulture);
                var capsuleNum = int.Parse(Console.ReadLine());

                var daysInMonth = DateTime.DaysInMonth(date.Year, date.Month);

                var price = capsulePrice * (decimal)capsuleNum * (decimal)daysInMonth;
                totalPrice += price;

                Console.WriteLine($"The price for the coffee is: ${price:F2}");
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
