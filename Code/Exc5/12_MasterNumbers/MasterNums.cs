using System;

namespace _12_MasterNumbers
{
    public class MasterNums
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= n; i++)
            {
                var iString = i.ToString();

                if (TestIfPalindrome(iString))
                {
                    if (SumDigits(iString) % 7 == 0)
                    {
                        if (TestIfHasEvenDigits(iString))
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
            }
        }


        public static bool TestIfPalindrome(string numStr)
        {

            for (int i = 0; i < numStr.Length / 2; i++)
            {
                if (numStr[i] !=numStr[numStr.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }

        public static bool TestIfHasEvenDigits(string numStr)
        {
            
            for (int i = 0; i < numStr.Length; i++)
            {
                if (int.Parse(numStr[i].ToString()) % 2 == 0)
                {
                    return true;
                }
            }

            return false;
        }


        public static int SumDigits(string numStr)
        {
            int sumDigits = 0;

            for (int i = 0; i < numStr.Length; i++)
            {
                sumDigits += int.Parse(numStr[i].ToString());
            }

            return sumDigits;
        }
    }
}
