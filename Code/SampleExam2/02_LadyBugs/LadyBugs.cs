using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LadyBugs
{
    public class LadyBugs
    {
        public static void Main()
        {
            var dim = int.Parse(Console.ReadLine());
            var field = new int[dim];

            for (int i = 0; i < dim; i++)
            {
                field[i] = 0;
            }

            var bugIndexes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            for (int j = 0; j < bugIndexes.Length; j++)
            {
                if (bugIndexes[j] >=0 && bugIndexes[j] < field.Length)
                {
                    field[bugIndexes[j]] = 1;
                }
            }

            var fly = Console.ReadLine();

            while (fly != "end")
            {
                var flySplit = fly.Split(' ').ToArray();

                var index = int.Parse(flySplit[0]);
                var direction = flySplit[1];
                var hops = int.Parse(flySplit[2]);

                if (index >= 0 && index < field.Length && field[index] == 1)
                {
                    field[index] = 0;
                    var newIndex = GetNewIndex(index, direction, hops);

                    while (newIndex >= 0 && newIndex < field.Length)
                    {
                        if (field[newIndex] == 0)
                        {
                            field[newIndex] = 1;
                            break;
                        }
                        else
                        {
                            newIndex = GetNewIndex(newIndex, direction, hops);
                        }
                    }
                }

                fly = Console.ReadLine();
            }

            Console.WriteLine(String.Join(" ", field));
        }

        public static int GetNewIndex(int index, string direction, int hops)
        {
            var nextIndex = index;

            if (direction == "right")
            {
                nextIndex += hops;
            }
            else if (direction == "left")
            {
                nextIndex -= hops;
            }

            return nextIndex;
        }
    }
}
