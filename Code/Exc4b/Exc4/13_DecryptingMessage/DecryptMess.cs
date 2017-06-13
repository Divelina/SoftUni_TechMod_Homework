using System;

namespace _13_DecryptingMessage
{
    public class DecryptMess
    {
        public static void Main()
        {
            var key = int.Parse(Console.ReadLine());
            var lineNum = int.Parse(Console.ReadLine());
            var decryptedText = string.Empty;

            for (int i = 1; i <= lineNum; i++)
            {
                var nextChar = char.Parse(Console.ReadLine());
                var newCode = (int)nextChar + key;

                decryptedText += (char)newCode;
            }

            Console.WriteLine(decryptedText);
        }
    }
}
