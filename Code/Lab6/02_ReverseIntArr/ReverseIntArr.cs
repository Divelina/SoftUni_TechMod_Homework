using System;
using System.Linq;

namespace _02_ReverseIntArr
{
    public class ReverseIntArr
    {
        public static void Main()
        {
            var arrLength = int.Parse(Console.ReadLine());
            var inputArr = new int[arrLength];

            for (var i=0; i < arrLength; i++)
            {
                inputArr[i] = int.Parse(Console.ReadLine());
            }

            var outputArr = new int[arrLength];

            for (var i = 0; i < inputArr.Length; i++)
            {
                outputArr[i] = inputArr[inputArr.Length - 1 - i];
            }

            Console.WriteLine(string.Join(" ", outputArr));
        }
    }
}
