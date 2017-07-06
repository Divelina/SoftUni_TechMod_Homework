using System;
using System.Text.RegularExpressions;

namespace _05_OnlyLetters
{
    public class OnlyLetters
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var pattern = @"([0-9]+)([a-zA-Z]{1})";
            var digitRegex = new Regex(pattern);

            MatchCollection digitLetter = digitRegex.Matches(input);

            foreach (Match sequence in digitLetter)
            {
                var digits = sequence.Groups[1].ToString();
                var letter = sequence.Groups[2].ToString();

                input = input.Replace(digits, letter);
            }

            Console.WriteLine(input);
        }
    }
}
