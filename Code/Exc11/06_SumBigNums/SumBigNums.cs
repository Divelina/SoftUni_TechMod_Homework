using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06_SumBigNums
{
    public class SumBigNums
    {
        public static void Main()
        {
            var num1 = Console.ReadLine();
            var num2 = Console.ReadLine();

            if (num1.Length > num2.Length)
            {
                num2 = AddFrontZeros(num2, num1.Length - num2.Length);
            }
            else if (num1. Length < num2.Length)
            {
                num1 = AddFrontZeros(num1, num2.Length - num1.Length);
            }

            var sum = string.Empty;
            var addToNextUnit = 0;

            for (int i = num1.Length -1; i >= 0 ; i--)
            {
                var sumDigits = addToNextUnit + int.Parse(num1[i].ToString())
                    + int.Parse(num2[i].ToString());

                if (sumDigits / 10 > 0)
                {
                    addToNextUnit = sumDigits / 10;
                    sumDigits %= 10;
                }
                else
                {
                    addToNextUnit = 0;
                }

                sum = sumDigits + sum;
            }

            if (addToNextUnit > 0)
            {
                sum = addToNextUnit + sum;
            }

            sum = sum.TrimStart('0');

            Console.WriteLine(sum);
        }

        public static string AddFrontZeros(string num, int v)
        {
            for (int i = 1; i <= v; i++)
            {
                num = 0 + num;
            }

            return num;
        }
    }
}
