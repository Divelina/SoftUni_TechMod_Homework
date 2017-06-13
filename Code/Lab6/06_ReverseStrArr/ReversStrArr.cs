using System;
using System.Linq;

namespace _06_ReverseStrArr
{
    public class ReversStrArr
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i < input.Length/2; i++)
            {
                var current = input[i];
                input[i] = input[input.Length - 1 - i];
                input[input.Length - 1 - i] = current;
            }

            Console.WriteLine(String.Join(" ", input));
        }
    }
}
