using System;

namespace _01_X
{
    public class X
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            //printing the upper part
            for (int i = 1; i <= n/2; i++)
            {
                var sideSpaces = new string(' ', i - 1);
                var midSpaces = new string(' ', n - 2*i);
                Console.WriteLine(sideSpaces + "x" + midSpaces + "x" + sideSpaces);
            }

            //printing the middle line
            var midSideSpaces = new string(' ', n / 2);
            Console.WriteLine(midSideSpaces + "x" + midSideSpaces);

            //printing the bootom line
            for (int i = n/2; i >=1 ; i--)
            {
                var sideSpaces = new string(' ', i - 1);
                var midSpaces = new string(' ', n - 2 * i);
                Console.WriteLine(sideSpaces + "x" + midSpaces + "x" + sideSpaces);
            }

        }
    }
}
