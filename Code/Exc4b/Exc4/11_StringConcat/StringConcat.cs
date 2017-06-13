using System;

namespace _11_StringConcat
{
    public class StringConcat
    {
        public static void Main()
        {
            var delimiter = Console.ReadLine();
            var position = Console.ReadLine();

            var lineNum = int.Parse(Console.ReadLine());

            var concatenatedString = string.Empty;
            int residual = 0;

            if (position == "odd")
            {
                residual = 1;
            }

            for (int i = 1; i <= lineNum; i++)
            {
                var nextString = Console.ReadLine();
                if (i % 2 == residual)
                {
                    concatenatedString += nextString + delimiter;
                }
            }

            concatenatedString = concatenatedString.Remove(concatenatedString.Length - 1);

            Console.WriteLine(concatenatedString);
        }
    }
}
