using System;

namespace _03_LastKSum
{
    public class LastKSum
    {
        public static void Main()
        {
            var totalElemNum = long.Parse(Console.ReadLine());
            var summedElemNum = long.Parse(Console.ReadLine());
            var outputArr = new long[totalElemNum];

            outputArr[0] = 1;

            for (long i = 1; i < totalElemNum; i++)
            {
                var sum = 0l;
                for (long j = i; j >= i - summedElemNum; j--)
                {
                    if (j >= 0)
                    {
                        sum += outputArr[j];
                    }
                }
                outputArr[i] = sum;
            }

            Console.WriteLine(string.Join(" ", outputArr));
        }
    }
}
