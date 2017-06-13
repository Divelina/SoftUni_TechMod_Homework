using System;

namespace _08_HouseBuilder
{
    public class HouseBuilder
    {
        public static void Main()
        {
            var firstPrice = Console.ReadLine();
            var secondPrice = Console.ReadLine();
            sbyte sbPrice;
            int intPrice;

            if (!sbyte.TryParse(firstPrice, out sbPrice))
            {
                sbyte.TryParse(secondPrice, out sbPrice);
                intPrice = int.Parse(firstPrice);
            }
            else
            {
                intPrice = int.Parse(secondPrice);
            }

            long totalPrice = 4 * (long)sbPrice + 10 * (long)intPrice;

            Console.WriteLine(totalPrice);
        }
    }
}
