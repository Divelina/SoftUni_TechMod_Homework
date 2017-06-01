using System;

namespace _04_VariableInHexadecimalFormat
{
    public class VarInHexDecFormat
    {
        public static void Main()
        {
            var hexdecNum = Console.ReadLine();
            var decimalNum = Convert.ToInt32(hexdecNum, 16);

            Console.WriteLine(decimalNum);
        }
    }
}
