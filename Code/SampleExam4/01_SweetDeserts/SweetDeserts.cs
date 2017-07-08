using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_SweetDeserts
{
    public class SweetDeserts
    {
        public static void Main()
        {
            var cash = decimal.Parse(Console.ReadLine());
            var guests = int.Parse(Console.ReadLine());
            var bananaPrice = decimal.Parse(Console.ReadLine());
            var eggPrice = decimal.Parse(Console.ReadLine());
            var berriesPrice = decimal.Parse(Console.ReadLine());

            var portions = Math.Ceiling(guests * 1.0m / 6);
            var moneyNeeded = (2 * bananaPrice + 4 * eggPrice + 0.2m * berriesPrice) * portions;

            if (cash >= moneyNeeded)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {moneyNeeded:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(moneyNeeded - cash):F2}lv more.");
            }
        }
    }
}
