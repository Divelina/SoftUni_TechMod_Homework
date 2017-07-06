using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_EmailMe
{
    class EmailMe
    {
        static void Main(string[] args)
        {
            var email = Console.ReadLine();
            var splitIndex = email.IndexOf('@');

            var begin = email.Substring(0, splitIndex);
            var end = email.Substring(splitIndex + 1);

            var result = CharSumBegin(begin) - CharSumBegin(end);

            if (result >= 0)
            {
                Console.WriteLine($"Call her!");
            }
            else
            {
                Console.WriteLine($"She is not the one.");
            }
        }

        public static int CharSumBegin(string str)
        {
            var charSum = 0;

            for (int i = 0; i < str.Length; i++)
            {
                charSum += (int)str[i];
            }

            return charSum;
        }
    }
}
