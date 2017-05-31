using System;

namespace _07_Greeting
{
    public class Greeting
    {
        public static void Main()
        {
            var firstName = Console.ReadLine();
            var lastName = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Hello, {firstName} {lastName}. \r\nYou are {age} years old.");
        }
    }
}
