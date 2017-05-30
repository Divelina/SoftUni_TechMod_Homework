using System;

namespace _11_OddNumber
{
    public class OddNumber
    {
        public static void Main()
        {
            int n = 0;

            while (true)
            {
                n = Math.Abs(int.Parse(Console.ReadLine()));
                if (n % 2 != 0)
                {
                    Console.WriteLine($"The number is: {n}");
                    break;
                }
                Console.WriteLine($"Please write an odd number.");
            }
        }
    }
}
