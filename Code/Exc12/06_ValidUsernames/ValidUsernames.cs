using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06_ValidUsernames
{
    public class ValidUsernames
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ', '\\', '/', '(', ')' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var pattern = @"^[a-zA-Z]{1}[a-zA-Z0-9_]{2,24}$";
            var usernameRegex = new Regex(pattern);

            var validUsernames = new List<string>();

            foreach (var entry in input)
            {
                if (usernameRegex.IsMatch(entry))
                {
                    validUsernames.Add(entry);
                }
            }

            var twoValuesLength = 0;
            var indexOfFirst = 0;

            for (int i = 0; i < validUsernames.Count -1; i++)
            {
                var currentLength = validUsernames[i].Length + validUsernames[i + 1].Length;
                if (currentLength > twoValuesLength)
                {
                    twoValuesLength = currentLength;
                    indexOfFirst = i;
                }
            }

            Console.WriteLine(validUsernames[indexOfFirst]);
            Console.WriteLine(validUsernames[indexOfFirst + 1]);

        }
    }
}
