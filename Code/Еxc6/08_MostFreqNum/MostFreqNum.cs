using System;
using System.Linq;

namespace _08_MostFreqNum
{
    public class MostFreqNum
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            
            var freqCount = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                var isFound = false;

                for (int j = 0; j < i; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        freqCount[j]++;
                        isFound = true;
                        break;
                    }
                }

                if (!isFound)
                {
                    freqCount[i] = 1;
                }
            }

            var maxFreq = freqCount.Max();

            var position = Array.IndexOf(freqCount, maxFreq);

            Console.WriteLine($"{arr[position]}");

        }
    }
}
