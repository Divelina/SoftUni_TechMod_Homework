using System;

namespace _06_IntervalOfNums
{
    public class IntervalOfNums
    {
        public static void Main()
        {
            var firstInteger = int.Parse(Console.ReadLine());
            var secondInteger = int.Parse(Console.ReadLine());

            int minNum = Math.Min(firstInteger, secondInteger);
            int maxNum = Math.Max(firstInteger, secondInteger);

            for (int i = minNum; i <= maxNum; i++)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
