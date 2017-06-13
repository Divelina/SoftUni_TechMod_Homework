using System;
using System.Linq;

namespace _10_PairsByDiff
{
    public class PairsByDiff
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var diff = int.Parse(Console.ReadLine());

            var countPairs = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (Math.Abs(arr[i] - arr[j]) == diff)
                    {
                        countPairs++;
                    }
                }
            }

            Console.WriteLine(countPairs);
        }
    }
}
