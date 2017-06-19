using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_ArrayStats
{
    public class ArrayStats
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var min = int.MaxValue;
            var max = int.MinValue;
            var sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }

                sum += arr[i];
            }

            var average = (double)sum / arr.Length;

            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
