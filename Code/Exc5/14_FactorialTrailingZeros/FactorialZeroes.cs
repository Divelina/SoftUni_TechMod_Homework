using System;
using System.Numerics;


namespace _14_FactorialTrailingZeros    
{
    public class FactorialZeroes
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factoriel = 1;
            int count = 0;
            BigInteger nonZeroProduct = 1;

            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
            }

            nonZeroProduct = factoriel;

            while (nonZeroProduct % 10 == 0)
            {
                count++;
                nonZeroProduct /= 10;
            }

            //if (count != 1)
            //{
            //    Console.WriteLine($"{n}! = {factoriel} -> {count} trailing zeroes");
            //}
            //else
            //{
            //    Console.WriteLine($"{n}! = {factoriel} -> One trailing zero");
            //}

            Console.WriteLine(count);
        }
    }
}
