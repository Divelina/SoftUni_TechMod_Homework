using System;

namespace _03_NameLastDigit
{
    public class NameLastDigit
    {
        public static void Main()
        {
            var number = long.Parse(Console.ReadLine());

            var lastDigit = FindLastDigit(number);

            var name = EnglishNameOfDigit(lastDigit);

            Console.WriteLine(name);
        }

        public static int FindLastDigit(long n)
        {
            var digit = Math.Abs(n) % 10;

            return (int)digit;
        }

        public static string EnglishNameOfDigit (int digit)
        {
            switch (digit)
            {
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default:
                    return "zero";
            }
        }
    }
}
