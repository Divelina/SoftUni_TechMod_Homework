using System;

namespace _08_SumOddNumbers
{
    public class SumOddNums
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 1; i < 2 * num; i+=2)
            {
                Console.WriteLine(i);
                sum += i;
            }

            Console.WriteLine($"Sum: {sum}");

        }
    }
}
