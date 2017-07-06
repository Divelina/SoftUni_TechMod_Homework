using System;
using System.Linq;
using System.Numerics;

namespace _02_ConvertFromBase
{
    public class ConvertFromBase
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();


            var bs = int.Parse(input[0]);
            var num = input[1];
            BigInteger numInDecimal = 0;

            for (int i = num.Length - 1; i >= 0; i--)
            {
                var j = num.Length - 1 - i;
                BigInteger pow = 1;
                for (int k = 1; k <= i; k++)
                {
                    pow *= bs;
                }
                numInDecimal += int.Parse(num[j].ToString()) * pow;
            }

            Console.WriteLine(numInDecimal);
        }
    }
}
