using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_UnicodeChar
{
    public class UnicodeChar
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var output = string.Empty;

            foreach (var ch in input)
            {
                output +=$"\\u{(int)ch:x4}";
            }

            Console.WriteLine(output);
        } 
    }
}
