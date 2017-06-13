using System;

namespace _06_PrimeChecker
{
    public class PrimeChecker
    {
        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine($"{isNumPrime(n)}");
            
        }

        public static bool isNumPrime(long n)
        {
            bool result = true;

            if (n < 2)
            {
                result = false;
            }
            else if (n == 2)
            {
                result = true;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
