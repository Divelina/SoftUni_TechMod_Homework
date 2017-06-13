using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_ChangeList
{
    public class ChangeList
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var command = Console.ReadLine();

            while (command != "Odd" && command != "Even")
            {
                var param = command.Split(' ').ToList();

                var element = int.Parse(param[1]);

                if (param[0] == "Delete")
                {
                    while (input.Contains(element))
                    {
                        input.Remove(element);
                    }
                }
                else if (param[0] == "Insert")
                {
                    var position = int.Parse(param[2]);
                    input.Insert(position, element);
                }

                command = Console.ReadLine();
            }

            if (command == "Odd")
            {
                input = input
                    .Where(e => (e % 2 == 1))
                    .ToList();
            }
            else
            {
                input = input
                    .Where(e => (e % 2 == 0))
                    .ToList();
            }

            Console.WriteLine(String.Join(" ", input));
        }
    }
}
