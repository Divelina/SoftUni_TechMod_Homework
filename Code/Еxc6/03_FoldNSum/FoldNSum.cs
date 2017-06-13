using System;
using System.Linq;

namespace _03_FoldNSum
{
    public class FoldNSum
    {
        public static void Main()
        {
            var inputArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var qrt = inputArr.Length / 4;

            var outputArr = new int[2 * qrt];

            var firstQuarter = inputArr
                .Where((e, i) => i < qrt)
                .Reverse()
                .ToArray();

            for (int i = 0; i < qrt; i++)
            {
                outputArr[i] = firstQuarter[i];
            }

            var lastQuarter = inputArr
                .Where((e, i) => i >= 3 * qrt)
                .Reverse()
                .ToArray();

            for (int i = qrt; i < 2*qrt; i++)
            {
                outputArr[i] = lastQuarter[i - qrt];
            }

            for (int i = 0; i < 2*qrt; i++)
            {
                outputArr[i] += inputArr[i + qrt];
            }

            Console.WriteLine(String.Join(" ",outputArr));
        }
    }
}
