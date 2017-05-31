using System;

namespace ExactSumRealNums
{
    public class ExactSumRealNums
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());
            decimal sum = 0m;

            for (int i = 1; i <= count; i++)
            {
                var nextNum = decimal.Parse(Console.ReadLine());
                sum += nextNum;
            }

            Console.WriteLine(sum);
        }
    }
}
