using System;
using System.Linq;

namespace _04_GrabNGo
{
    public class GrabNGo
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var num = int.Parse(Console.ReadLine());
            
            var lastPosition = -1;

            for (int i = arr.Length -1; i >= 0; i--)
            {
                if (arr[i] == num)
                {
                    lastPosition = i;
                    break;
                }
            }

            long sumPrevious = 0L;

            if (lastPosition >= 0)
            {
                for (int i = 0; i < lastPosition; i++)
                {
                    sumPrevious += arr[i];
                }

                Console.WriteLine(sumPrevious);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
