using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_LongestIncrSeq
{
    public class LongestIncrSeq
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var maxEndingAtIndex = new int[input.Length];
            var previousIndex = new int[input.Length];

            maxEndingAtIndex[0] = 1;
            previousIndex[0] = -1;

            var totalMaxLength = 1;
            var totalMaxLengthIndex = 0;

            for (int i = 1; i < input.Length; i++)
            {
                var maxPrevLength = 0;
                var prevIndex = -1;

                for (int j = 0; j < i; j++)
                {
                    if ((input[i] > input[j]) && (maxEndingAtIndex[j] > maxPrevLength))
                    {
                        maxPrevLength = maxEndingAtIndex[j];
                        prevIndex = j;
                    }

                    maxEndingAtIndex[i] = maxPrevLength + 1;
                    previousIndex[i] = prevIndex;                    
                }

                if (maxEndingAtIndex[i] > totalMaxLength)
                {
                    totalMaxLength = maxEndingAtIndex[i];
                    totalMaxLengthIndex = i;
                }
            }

            //Console.WriteLine(String.Join(" ", maxEndingAtIndex));
            //Console.WriteLine(String.Join(" ", previousIndex));

            var output = new List<int>();

            output.Add(input[totalMaxLengthIndex]);
            var prevIndexToAdd = previousIndex[totalMaxLengthIndex];

            while (prevIndexToAdd >= 0)
            {
                output.Insert(0,input[prevIndexToAdd]);
                prevIndexToAdd = previousIndex[prevIndexToAdd];
            }

            Console.WriteLine(String.Join(" ", output));

        }
    }
}
