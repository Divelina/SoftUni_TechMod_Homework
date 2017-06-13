using System;
using System.Linq;

namespace _06_MaxSeqEquals
{
    public class MaxSeqEquals
    {
        public static void Main()
        {
            var intArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var element = intArr[0];
            var reps = 1;

            var maxRepEl = element;
            var maxReps = reps;

            for (int i = 1; i < intArr.Length; i++)
            {
                if (intArr[i] == element)
                {
                    reps++;
                }
                else
                {
                    if (reps > maxReps)
                    {
                        maxReps = reps;
                        maxRepEl = element;
                    }

                    element = intArr[i];
                    reps = 1;
                }
            }

            if (reps > maxReps)
            {
                maxReps = reps;
                maxRepEl = element;
            }

            var result = string.Empty;
            for (int i = 0; i < maxReps; i++)
            {
                result += $"{maxRepEl}" + " ";
            }

            Console.WriteLine(result);

        }
    }
}
