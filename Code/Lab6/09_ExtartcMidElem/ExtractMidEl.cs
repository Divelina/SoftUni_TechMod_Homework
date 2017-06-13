using System;
using System.Linq;

namespace _09_ExtartcMidElem
{
    public class ExtractMidEl
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var dim = input.Length;

            var result = string.Empty;

            if (dim == 1)
            {
                result = $"{{ {input[0]} }}";
            }
            else if (dim % 2 == 0)
            {
                var output = new int[]
                {
                    input[dim/2 - 1],
                    input[dim/2]
                };

                result = $"{{ {String.Join(", ", output)} }}";
            }
            else
            {
                var output = new int[]
                {
                    input[dim/2 - 1],
                    input[dim/2],
                    input[dim/2 + 1]
                };

                result = $"{{ {String.Join(", ", output)} }}";
            }

            Console.WriteLine(result);
        }
    }
}
