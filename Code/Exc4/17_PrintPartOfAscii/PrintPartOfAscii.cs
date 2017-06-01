using System;

namespace _17_PrintPartOfAscii
{
   public class PrintPartOfAscii
    {
        public static void Main()
        {
            var startIndex = int.Parse(Console.ReadLine());
            var endIndex = int.Parse(Console.ReadLine());

            for (int i = startIndex; i <= endIndex; i++)
            {
                var printChar = (char)i;
                Console.Write(printChar + " ");
            }
        }
    }
}
