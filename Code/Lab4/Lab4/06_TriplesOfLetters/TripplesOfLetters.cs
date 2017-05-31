using System;

namespace _06_TriplesOfLetters
{
    public class TripplesOfLetters
    {
        public static void Main()
        {
            var lettersNum = int.Parse(Console.ReadLine());
            var lastChar = (char)('a' + lettersNum - 1);

            for (char c1 = 'a'; c1 <= lastChar; c1++)
            {
                for (char c2 = 'a'; c2 <= lastChar; c2++)
                {
                    for (char c3 = 'a'; c3 <= lastChar; c3++)
                    {
                        Console.WriteLine($"{c1}{c2}{c3}");
                    }
                }
            }
        }
    }
}
