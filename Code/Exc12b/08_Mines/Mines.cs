using System;
using System.Text.RegularExpressions;

namespace _08_Mines
{
    public class Mines
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            var pattern = @"<(.{2})>";
            var mineRegex = new Regex(pattern);

            MatchCollection mines = mineRegex.Matches(inputLine);

            foreach (Match mine in mines)
            {
                var minePower = CalculateMinePower(mine);

                var startIndex = mine.Index - minePower;
                if (startIndex < 0)
                {
                    startIndex = 0;
                }

                var endIndex = mine.Index + mine.Length + minePower - 1;
                if (endIndex >= inputLine.Length)
                {
                    endIndex = inputLine.Length - 1;
                }
                
                var eraseLength = endIndex + 1 - startIndex;
                var toErase = inputLine.Substring(startIndex, eraseLength);
                var dashes = new string('_', eraseLength);

                inputLine = inputLine.Replace(toErase, dashes);
                
            }

            Console.WriteLine(inputLine);
        }

        public static int CalculateMinePower(Match mine)
        {
            var firstChar = mine.Groups[1].ToString()[0];
            var secondChar = mine.Groups[1].ToString()[1];

            var power = Math.Abs(firstChar - secondChar);

            return power;
        }
    }
}
