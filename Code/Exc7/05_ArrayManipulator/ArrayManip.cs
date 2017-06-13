using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_ArrayManipulator
{
    public class ArrayManip
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var command = Console.ReadLine();

            while (command != "print")
            {
                var com = command.Split(' ').ToArray();

                if (com[0] == "add")
                {
                    input.Insert(int.Parse(com[1]), int.Parse(com[2]));
                }
                else if (com[0] == "addMany")
                {
                    var index = int.Parse(com[1]);

                    for (int i = 2; i < com.Length; i++)
                    {
                        input.Insert(index, int.Parse(com[i]));
                        index++;
                    }
                }
                else if (com[0] == "contains")
                {
                    var elem = int.Parse(com[1]);
                    if (input.Contains(elem))
                    {
                        Console.WriteLine(input.IndexOf(elem));
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                else if (com[0] == "remove")
                {
                    input.RemoveAt(int.Parse(com[1]));
                }
                else if (com[0] == "shift")
                {
                    var pos = int.Parse(com[1]) % (input.Count);

                    for (int j = 1; j <= pos; j++)
                    {
                        var el = input[0];
                        input.RemoveAt(0);
                        input.Add(el);
                    }
                }
                else if (com[0] == "sumPairs")
                {
                    for (int j = 0; j < input.Count -1; j++)
                    {
                        input[j] += input[j + 1];
                        input.RemoveAt(j + 1);
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"[{String.Join(", ", input)}]");
        }
    }
}
