using System;
using System.Linq;

namespace _09_IndexOfLetters
{
    public class IndexLetters
    {
        public static void Main()
        {
            var smallLatinArr = new char[26];

            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                var index = (int)ch - (int)'a';
                smallLatinArr[index] = ch; 
            }


            var word = Console.ReadLine();

            for (int i = 0; i < word.Length; i++)
            {
                var letterInd = Array.IndexOf(smallLatinArr, word[i]);

                Console.WriteLine($"{word[i]} -> {letterInd}");
            }
        }
    }
}
