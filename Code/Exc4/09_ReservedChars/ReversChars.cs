using System;

namespace _09_ReversedChars
{
    public class ReversChars
    {
        public static void Main()
        {
            var reversedChars = string.Empty;

            for (int i = 0; i < 3; i++)
            {
                var nextChar = char.Parse(Console.ReadLine());

                reversedChars = nextChar.ToString() + reversedChars;
            }

            Console.WriteLine(reversedChars);
        }
    }
}
