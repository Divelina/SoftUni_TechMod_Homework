using System;
using System.Linq;

namespace _07_MaxIncrSequence
{
    class MaxIncrSequence
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var result = arr[0].ToString();
            var finalResult = arr[0].ToString();
            var countSeq = 1;
            var maxSeq = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > arr[i-1])
                {
                    result += " " + arr[i].ToString();
                    countSeq++;
                }
                else
                {
                    if (countSeq > maxSeq)
                    {
                        maxSeq = countSeq;
                        finalResult = result;
                    }

                    result = arr[i].ToString();
                    countSeq = 1;
                }
            }

            if (countSeq > maxSeq)
            {
                maxSeq = countSeq;
                finalResult = result;
            }

            Console.WriteLine(finalResult);
        }
    }
}
