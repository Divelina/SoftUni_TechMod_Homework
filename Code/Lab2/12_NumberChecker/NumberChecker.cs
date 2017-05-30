using System;

namespace _12_NumberChecker
{
    public class NumberChecker
    {
        public static void Main()
        {
            try
            {
                var num = int.Parse(Console.ReadLine());
                Console.WriteLine($"It is a number.");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Invalid input!");
            }
        }
    }
}
