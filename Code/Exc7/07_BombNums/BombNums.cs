using System;
using System.Collections.Generic;
using System.Linq;

namespace _07_BombNums
{
    public class BombNums
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var bombs = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var bomb = bombs[0];
            var power = bombs[1];

            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == bomb)
                {
                    var startPos = i - power;
                    var endPos = i + power;
                    
                    if (startPos <0)
                    {
                        startPos = 0;
                    }

                    if (endPos > input.Count - 1)
                    {
                        endPos = input.Count - 1; 
                    }

                    var count = endPos - startPos + 1;
                    input.RemoveRange(startPos, count);

                    i = endPos - count;
                }
            }

            //Console.WriteLine(String.Join(" ", input));

            Console.WriteLine(input.Sum());
        }
    }
}
