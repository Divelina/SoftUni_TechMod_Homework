using System;

namespace _06_StringsAndObjects
{
    public class StringsAndObjects
    {
        public static void Main()
        {
            string firstString = "Hello";
            string secondString = "World";

            object theObject = firstString + " " + secondString;

            string output = (string) theObject;

            Console.WriteLine(output);
        }
    }
}
