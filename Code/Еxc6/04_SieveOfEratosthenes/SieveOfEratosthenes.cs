using System;
using System.Linq;

namespace _04_SieveOfEratosthenes
{
    public class SieveOfEratosthenes
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var isPrime = new bool[n];

            isPrime[0] = false;

            for (var i = 1; i < n; i++)
            {
                isPrime[i] = true;
            }

            for (var i = 1; i < n; i++)
            {
                if (isPrime[i] == true)
                {
                    for (int j = (i+1) * (i+1); j <= n; j+=i+1)
                    {
                        isPrime[j -1] = false;
                    }
                }
            }

            var primes = isPrime
                .Select((e, i) => e == true ? i+1 : 0)
                .Where(el => el > 0)
                .ToArray();

            Console.WriteLine(String.Join(" ", primes));
        }
    }
}
