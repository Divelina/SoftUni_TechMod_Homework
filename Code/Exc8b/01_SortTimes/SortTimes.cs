using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _01_SortTimes
{
    public class SortTimes
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ')
                .Select(s => DateTime.ParseExact(s, "HH:mm", CultureInfo.InvariantCulture))
                .ToList();

            input.Sort();
            var output = new List<string>();

            output = input.Select(d => d.ToString("HH:mm")).ToList();

            Console.WriteLine(String.Join(", ", output));
        }
    }
}
