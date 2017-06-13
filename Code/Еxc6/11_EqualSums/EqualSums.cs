using System;
using System.Linq;

namespace _11_EqualSums
{
    public class EqualSums
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var leftSum = 0;
            var rightSum = arr.Sum();

            var splitSumIndex = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                rightSum -= arr[i];

                if (leftSum == rightSum)
                {
                    splitSumIndex = i;
                    break;
                }

                leftSum += arr[i];  
            }

            if (splitSumIndex >= 0)
            {
                Console.WriteLine(splitSumIndex);
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
