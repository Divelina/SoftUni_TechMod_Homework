using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_NumsInReverseOrder
{
    public class ReverseDigits
    {
        public static void Main()
        {
            var num = Console.ReadLine();
            var result = string.Empty;

            for (int i = num.Length -1; i >= 0; i--)
            {
                result += num[i];
            }

            Console.WriteLine(result);
        }
    }
}
