using System;
using System.Numerics;

namespace _13_Factorial
{
    public class Factorial
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factoriel = 1;


            for (int i = 1; i <= n; i++)
            {
                factoriel *= i;
            }

            Console.WriteLine(factoriel);
        }
    }
}
