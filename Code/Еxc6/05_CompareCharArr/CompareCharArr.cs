using System;
using System.Linq;

namespace _05_CompareCharArr
{
    public class CompareCharArr
    {
        public static void Main()
        {
            var pArr = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();

            var sArr = Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();

            var isFirstBigger = true;
            var isEqual = true;

            var minDim = Math.Min(pArr.Length, sArr.Length);

            for (int i = 0; i < minDim; i++)
            {
                if (sArr[i].CompareTo(pArr[i]) > 0)
                {
                    isFirstBigger = false;
                    isEqual = false;
                    break;
                }
                else if (sArr[i].CompareTo(pArr[i]) < 0)
                {
                    isEqual = false;
                    break;
                }
            }
            
            if (isEqual && (sArr.Length > pArr.Length))
            {
                isFirstBigger = false;
            }

            if (isFirstBigger)
            {
                Console.WriteLine(String.Join("", sArr));
                Console.WriteLine(String.Join("", pArr));
            }
            else
            {
                Console.WriteLine(String.Join("", pArr));
                Console.WriteLine(String.Join("", sArr));
            }
        }
    }
}
