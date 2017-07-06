using System;
using System.Linq;
using System.Numerics;

namespace ConvertBasesOfNum
{
    public class ConvertBases
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            var bs = BigInteger.Parse(input[0]);
            var numInDecimal = BigInteger.Parse(input[1]);

            var strNum = (numInDecimal % bs).ToString();

            while (numInDecimal / bs > 0)
            {
                numInDecimal = numInDecimal / bs;
                var residual = numInDecimal % bs;

                strNum = residual + strNum;
            }

            Console.WriteLine(strNum);
        }
    }
}
