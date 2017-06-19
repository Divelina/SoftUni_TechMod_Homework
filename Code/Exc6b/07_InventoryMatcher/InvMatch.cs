using System;
using System.Linq;

namespace _07_InventoryMatcher
{
    public class InvMatch
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
                for (int i = 0; i < products.Length; i++)
                {
                    if (products[i] == nextProd)
                    {
                        Console.WriteLine($"{products[i]} costs: {price[i]}; Available quantity: {quant[i]}");
                        break;
                    }
                }

                nextProd = Console.ReadLine();
            }
        }
    }
}
