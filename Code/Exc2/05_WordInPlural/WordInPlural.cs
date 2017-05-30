using System;
using System.Text.RegularExpressions;

namespace _05_WordInPlural
{
    public class WordInPlural
    {
        public static void Main()
        {
            var noun = Console.ReadLine();
            var plural = string.Empty;

            var pattern1 = @".*?(o|ch|s|sh|x|z)$";
            var pattern2 = @".*?y$";

            var regex1 = new Regex(pattern1);
            var regex2 = new Regex(pattern2);

            if (regex1.IsMatch(noun))
            {
                plural = noun + "es";
            }
            else if (regex2.IsMatch(noun))
            {
                plural = noun.Remove(noun.Length - 1) + "ies";
            }
            else
            {
                plural = noun + "s";
            }

            Console.WriteLine($"{plural}");
        }
    }
}
