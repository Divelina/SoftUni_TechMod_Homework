using System;
using System.Linq;

namespace _08_CondenseArr
{
    public class CondenseArr
    {
        public static void Main()
        {
            var inputArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var dim = inputArr.Length;

            while (dim > 1)
            {
                for (int i = 0; i < dim - 1; i++)
                {
                    inputArr[i] += inputArr[i + 1];
                }
                dim--;
            }

            Console.WriteLine(inputArr[0]);
        }
    }
}
