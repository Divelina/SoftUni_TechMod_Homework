using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _03_RageQuit
{
    public class RageQuit
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var outString = new StringBuilder();
            var uniqueChars = new HashSet<char>();

            var pattern = @"([^\d]{1,20})(\d{1,2})";
            var msgRegex = new Regex(pattern);

            MatchCollection messages = msgRegex.Matches(input);

            foreach (Match item in messages)
            {
                var symbols = item.Groups[1].ToString().ToUpper();
                var reps = int.Parse(item.Groups[2].ToString());

                if (reps > 0)
                {
                    foreach (var ch in symbols)
                    {
                        uniqueChars.Add(ch);
                    }
                }
                
                for (int i = 1; i <= reps; i++)
                {
                    outString.Append(symbols);
                }
            }

            var output = outString.ToString();

            Console.WriteLine($"Unique symbols used: {uniqueChars.Count}");
            Console.WriteLine(output);
        }
    }
}
