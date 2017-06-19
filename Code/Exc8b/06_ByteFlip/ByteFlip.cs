using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_ByteFlip
{
    public class ByteFlip
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(' ')
                .Where(s => s.Length == 2)
                .Select(s => s[1].ToString() + s[0].ToString())
                .Reverse()
                .Select(s => (char)Int32.Parse(s, System.Globalization.NumberStyles.HexNumber))
                .ToList();

            Console.WriteLine(String.Join("", input));
        }
    }
}
