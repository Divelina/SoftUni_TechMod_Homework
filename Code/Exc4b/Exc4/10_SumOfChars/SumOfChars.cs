using System;

namespace _10_SumOfChars
{
    public class SumOfChars
    {
        public static void Main()
        {
            var lineNum = int.Parse(Console.ReadLine());
            var asciiSum = 0;

            for (int i = 1; i <= lineNum; i++)
            {
                asciiSum += (int)char.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The sum equals: {asciiSum}");
        }
    }
}
