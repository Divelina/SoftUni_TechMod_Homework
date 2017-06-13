using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_SumRevrsNum
{
    public class SumRevrsNum
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .ToList();

            var output = new List<double>();

            for (int i = 0; i < input.Count; i++)
            {
                var reversed = Reverse(input[i]);
                output.Add(double.Parse(reversed));
            }

            var sum = output.Sum();

            //Console.WriteLine(String.Join(" ", output));
            Console.WriteLine(sum);
        }

        public static string Reverse(string v)
        {
            var result = string.Empty;


            for (int i=v.Length -1; i >= 0; i--)
            {
                result += v[i];
            }

            return result;
        }
    }
}
