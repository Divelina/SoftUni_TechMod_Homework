using System;

namespace _05_SpecialNums
{
    class SpecialNums
    {
        static void Main(string[] args)
        {
            var maxNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= maxNum; i++)
            {
                bool isNumSpecial = false;
                if (SumOfDigits(i) == 5 || SumOfDigits(i) == 7 || SumOfDigits(i) == 11)
                {
                    isNumSpecial = true;
                }

                Console.WriteLine($"{i} -> {isNumSpecial}");
            }
        }

        public static int SumOfDigits(int num)
        {
            var numString = num.ToString();
            var sum = 0;
            
            for (int i = 0; i < numString.Length; i++)
            {
                sum += (int)(numString[i] - '0');
            }

            return sum;
        }
    }
}
