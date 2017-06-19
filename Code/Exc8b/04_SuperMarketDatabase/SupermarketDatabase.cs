using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_SuperMarketDatabase
{
    public class SupermarketDatabase
    {
        public static void Main()
        {
            var products = new Dictionary<string, double[]>();

            var newLine = Console.ReadLine();

            while (newLine != "stocked")
            {
                var splitLine = newLine.Split(' ').ToArray();

                var productName = splitLine[0];
                var productPrice = double.Parse(splitLine[1]);
                var productQuantity = double.Parse(splitLine[2]);

                if (!products.ContainsKey(productName))
                {
                    products[productName] = new double[2];
                    products[productName][1] = 0;
                }

                products[productName][0] = productPrice;
                products[productName][1] += productQuantity;

                newLine = Console.ReadLine();
            }

            foreach (var item in products)
            {
                var total = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key}: ${item.Value[0]:F2} * {item.Value[1]:F0} = ${total:F2}");
            }

            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${products.Sum(p => p.Value[0] *p.Value[1]):F2}");
        }
    }
}
