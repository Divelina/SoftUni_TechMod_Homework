using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_OddFilter
{
    public class OddFilter
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            input = input
                .Where(n => n % 2 == 0)
                .ToList();

            input = input
                .Select(n => n > input.Average() ? n + 1 : n - 1)
                .ToList();

            Console.WriteLine(String.Join(" ", input));
        }
    }
}
