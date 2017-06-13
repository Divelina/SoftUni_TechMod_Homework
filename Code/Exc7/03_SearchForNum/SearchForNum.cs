using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_SearchForNum
{
   public class SearchForNum
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var select = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var takenNum = select[0];
            var delNum = select[1];
            var searched = select[2];

            var output = new List<int>();

            for (int i = delNum; i < takenNum; i++)
            {
                output.Add(input[i]);
            }

            //Console.WriteLine(String.Join(" ", output));

            if (output.Contains(searched))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
