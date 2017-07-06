using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02_ExtractSentencesByKeyWord
{
   public class ExtractByKeyWord
    {
        public static void Main()
        {
            var searchedWord = Console.ReadLine();
            var pattern = @"[A-Z]+[^\.!?]*\b" + searchedWord + @"\b.*?[\.!?]";
            var sentenceRegex = new Regex(pattern);

            var text = Console.ReadLine();
            MatchCollection sentences = sentenceRegex.Matches(text);

            foreach (var item in sentences)
            {
                var current = item.ToString().Trim(new char[] { '.', '?', '!' });
                Console.WriteLine(current);
            }
        }
    }
}
