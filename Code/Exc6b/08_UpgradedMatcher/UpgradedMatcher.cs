using System;
using System.Linq;

namespace _08_UpgradedMatcher
{
    public class UpgradedMatcher
    {
        public static void Main()
        {
            var products = Console.ReadLine()
                .Split(' ')
                .ToArray();

            var quant = Console.ReadLine()
                .Split(' ')
                .Select(long.Parse)
                .ToArray();

            var price = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToArray();

            var nextProd = Console.ReadLine();

            while (nextProd != "done")
            {
                var splitOrder = nextProd.Split(' ').ToArray();

                var prod = splitOrder[0];
                var itemNum = long.Parse(splitOrder[1]);

                var position = Array.IndexOf(products, prod);
                var currentPrice = price[position];
                var quantity = 0L;

                if (position < quant.Length)
                {
                    quantity = quant[position];
                }

                if (quantity >= itemNum)
                {
                    Console.WriteLine($"{prod} x {itemNum} costs {itemNum * currentPrice:F2}");
                    quant[position] -= itemNum;
                }
                else
                {
                    Console.WriteLine($"We do not have enough {prod}");
                }

                nextProd = Console.ReadLine();
            }
        }
    }
}
