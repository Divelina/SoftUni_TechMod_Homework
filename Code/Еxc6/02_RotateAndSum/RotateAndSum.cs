using System;
using System.Linq;

namespace _02_RotateAndSum
{
    public class RotateAndSum
    {
        public static void Main()
        {
            var inputArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var rots = int.Parse(Console.ReadLine());

            var summedArr = new int[inputArr.Length];

            for (var k = 1; k <= rots % inputArr.Length; k++)
            {
                inputArr = RotateArrRight(inputArr);

                for (var i = 0; i < inputArr.Length; i++)
                {
                    summedArr[i] += inputArr[i];
                }
            }

            if (rots / inputArr.Length > 0)
            {
                var fullRotations = rots / inputArr.Length;

                var sumElements = inputArr.Sum();

                summedArr = summedArr
                    .Select(el => el + fullRotations * sumElements)
                    .ToArray();
            }

            Console.WriteLine($"{String.Join(" ", summedArr)}");
        }

        public static int[] RotateArrRight(int[] arr)
        {
            var lastEl = arr[arr.Length -1];

            for (int i = arr.Length -1 ; i > 0 ; i--)
            {
                arr[i] = arr[i-1];
            }

            arr[0] = lastEl;

            return arr;
        }
    }
}
