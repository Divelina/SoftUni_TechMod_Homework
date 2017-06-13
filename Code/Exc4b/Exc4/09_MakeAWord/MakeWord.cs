using System;

namespace _09_MakeAWord
{
    public class MakeWord
    {
        public static void Main()
        {
            var lineNumber = int.Parse(Console.ReadLine());
            var word = string.Empty;

            for (int i = 1; i <= lineNumber; i++)
            {
                word += char.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The word is: {word}");
        }
    }
}
