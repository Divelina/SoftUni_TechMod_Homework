using System;

namespace _15_FastPrimeChecker
{
    public class FastPrimeChecker
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            for (int numInRange = 2; numInRange <= input; numInRange++)
            {
                bool isNotPrime = true;
                for (int divider = 2; divider <= Math.Sqrt(numInRange); divider++)
                {
                    if (numInRange % divider == 0)
                    {
                        isNotPrime = false;
                        break;
                    }
                }
                Console.WriteLine($"{numInRange} -> {isNotPrime}");
            }
        }
    }
}
