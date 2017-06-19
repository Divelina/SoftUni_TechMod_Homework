using System;
using System.Linq;

namespace _09_JumpAround
{
    public class JumpAround
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var sum = arr[0];
            var index = 0;
            var newIndex = arr[0];

            while (true)
            {
                if (index + newIndex < arr.Length)
                {
                    index += newIndex;
                    sum += arr[index];
                    newIndex = arr[index];
                }
                else if (index - newIndex >= 0)
                {
                    index -= newIndex;
                    sum += arr[index];
                    newIndex = arr[index];
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
