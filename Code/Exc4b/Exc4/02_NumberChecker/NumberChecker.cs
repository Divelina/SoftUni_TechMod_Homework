using System;

namespace _02_NumberChecker
{
   public class NumberChecker
    {
        public static void Main()
        {
            var num = Console.ReadLine();
            var result = 0l;

            if (long.TryParse(num, out result))
            {
                Console.WriteLine("integer");
            }
            else
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
