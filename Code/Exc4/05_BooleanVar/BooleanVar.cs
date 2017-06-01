using System;

namespace _05_BooleanVar
{
    public class BooleanVar
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var booleanVar = Convert.ToBoolean(input);

            if (booleanVar)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
