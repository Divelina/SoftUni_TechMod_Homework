using System;
using System.Linq;
using System.Collections.Generic;

namespace _07_PrimesInGivenRange
{
    public class PrimesInRange
    {
        public static void Main()
        {
            long startInt = long.Parse(Console.ReadLine());
            long endInt = long.Parse(Console.ReadLine());

            var output = string.Join(", ",ListPrimesInRange(startInt, endInt));

            Console.WriteLine(output);
        }

        public static List<long> ListPrimesInRange (long start, long end)
        {
            var result = new List<long>();

            for (long i = start; i <= end; i++)
            {
                if (isNumPrime(i))
                {
                    result.Add(i);
                }
            }

            return result;
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
