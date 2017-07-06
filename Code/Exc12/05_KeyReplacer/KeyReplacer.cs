using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05_KeyReplacer
{
    public class KeyReplacer
    {
        public static void Main()
        {
            var keys = Console.ReadLine();

            var startPattern = @"^(.+?)(<|\||\\)";
            var regexStart = new Regex(startPattern);
            var startKey = regexStart.Match(keys).Groups[1].ToString();

            var endPattern = @"(<|\||\\)([^<\|\\]+)$";
            var regexEnd = new Regex(endPattern);
            var endKey = regexEnd.Match(keys).Groups[2].ToString();

            var searched = Console.ReadLine();
            var pattern = startKey + @"(.*?)" + endKey;
            var regex = new Regex(pattern);
            MatchCollection extracted = regex.Matches(searched);

            var result = string.Empty;

            foreach (Match match in extracted)
            {
                result += match.Groups[1].ToString();
            }

            if (result.Length == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(result);
            }

        }
    }
}
