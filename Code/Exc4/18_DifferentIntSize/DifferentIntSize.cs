using System;

namespace _18_DifferentIntSize
{
    public class DifferentIntSize
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var typeString = string.Empty;

            try
            {
                var parsedNum = long.Parse(input);
                typeString += "* long\r\n";
            }
            catch { }

            try
            {
                var parsedNum = uint.Parse(input);
                typeString = "* uint\r\n" + typeString;
            }
            catch { }

            try
            {
                var parsedNum = int.Parse(input);
                typeString = "* int\r\n" + typeString;
            }
            catch { }

            try
            {
                var parsedNum = ushort.Parse(input);
                typeString = "* ushort\r\n" + typeString;
            }
            catch { }

            try
            {
                var parsedNum = short.Parse(input);
                typeString = "* short\r\n" + typeString;
            }
            catch { }

            try
            {
                var parsedNum = byte.Parse(input);
                typeString = "* byte\r\n" + typeString;
            }
            catch { }

            try
            {
                var parsedNum = sbyte.Parse(input);
                typeString = "* sbyte\r\n" + typeString;
            }
            catch { }

            if  (typeString.Length > 0)
            {
                Console.WriteLine($"{input} can fit in:");
                Console.WriteLine($"{typeString}");
            }
            else
            {
                Console.WriteLine($"{input} can't fit in any type");
            }
        }
    }
}
