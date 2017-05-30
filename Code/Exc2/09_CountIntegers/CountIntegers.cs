using System;

namespace _09_CountIntegers
{
    public class CountIntegers
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var countIntNum = 0;

            while (true)
            {
                try
                {
                    var n = int.Parse(input);
                    countIntNum++;
                }
                catch
                {
                    break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(countIntNum);
        }
    }
}
