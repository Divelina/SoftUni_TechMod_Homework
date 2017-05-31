using System;

namespace _09_RefactorSpecialNums
{
    public class RefactorSpecialNums
    {
        public static void Main()
        {
            int lettersNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= lettersNum; i++)
            {
                var sumDigit = 0;
                var currentNum = i;
                while (currentNum > 0)
                {
                    sumDigit += currentNum % 10;
                    currentNum = currentNum / 10;
                }

                bool isSpecial = (sumDigit == 5) || (sumDigit == 7) || (sumDigit == 11);
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
