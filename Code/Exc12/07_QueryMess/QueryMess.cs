using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07_QueryMess
{
    public class QueryMess
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            while (inputLine !="END")
            {
                var kVP = new Dictionary<string, List<string>>();
                var pairs = inputLine
                    .Split(new char[] { '&', '?' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var pattern = @"(.*?)=(.*)";
                var regex = new Regex(pattern);

                var whitespacePattern = @"(\+|%20)+";
                var spaceRegex = new Regex(whitespacePattern);

                for (int i = 0; i < pairs.Length; i++)
                {
                    if (regex.IsMatch(pairs[i]))
                    {
                        var match = regex.Match(pairs[i]);
                        var firstWord = match.Groups[1].ToString();
                        var secondWord = match.Groups[2].ToString();

                        var key = spaceRegex.Replace(firstWord, " ").ToString().Trim();
                        var value = spaceRegex.Replace(secondWord, " ").ToString().Trim();

                        if (!kVP.ContainsKey(key))
                        {
                            kVP[key] = new List<string>();
                        }

                        kVP[key].Add(value);
                    }
                }

                foreach (var kvp in kVP)
                {
                    Console.Write($"{kvp.Key}=[{String.Join(", ", kvp.Value)}]");
                }
                Console.WriteLine();

                inputLine = Console.ReadLine();
            }
        }
    }
}
