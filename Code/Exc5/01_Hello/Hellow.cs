using System;

namespace _01_Hello
{
    public class Hellow
    {
        public static void Main()
        {
            var name = Console.ReadLine();

            var result = SayHello(name);

            Console.WriteLine(result);
        }

        public static string SayHello(string theName)
        {
            return $"Hello, {theName}!";
        }
    }
}
