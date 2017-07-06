using System;

namespace Censorship
{
    public class Program
    {
        public static void Main()
        {
            var bannedWord = Console.ReadLine();
            var sentence = Console.ReadLine();

            sentence = sentence.Replace(bannedWord, new string('*', bannedWord.Length));

            Console.WriteLine(sentence);
        }
    }
}
