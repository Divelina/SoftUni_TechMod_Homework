using System;

namespace _05_FibonacciNumbers
{
    public class FibonacciNums
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var nthFibonacciNum = Fib(n);

            Console.WriteLine(nthFibonacciNum);
        }

        public static int Fib(int n)
        {
            var fibNumPrevious = 0;
            var fibNumCurrent = 1;
            var fibNumNext = 0;

            for (int i = 1; i <= n; i++)
            {
                fibNumNext = fibNumPrevious + fibNumCurrent;
                fibNumPrevious = fibNumCurrent;
                fibNumCurrent = fibNumNext;
            }

            return fibNumCurrent;
        }
    }
}
