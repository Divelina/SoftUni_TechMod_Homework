using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_MaxSeqEquals
{
    public class MaxSeqEquals
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var output = new List<int>();
            var current = new List<int>();
            current.Add(input[0]);

            for (int i = 1; i < input.Count; i++)
            {
                if (input[i] != input[i-1])
                {
                    if (current.Count > output.Count)
                    {
                        output.Clear();
                        for (int j = 0; j < current.Count; j++)
                        {
                            output.Add(current[j]);
                        }
                    }
                    current.Clear();
                }

                current.Add(input[i]);
            }

            if (current.Count > output.Count)
            {
                output.Clear();
                for (int j = 0; j < current.Count; j++)
                {
                    output.Add(current[j]);
                }
            }

            Console.WriteLine(String.Join(" ", output));
        }
    }
}
