using System;
using System.Linq;

namespace _08_LettersChangeNums
{
    public class LettersChangeNums
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ','\t' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var sum = 0.0d;

            foreach (var item in input)
            {
                var num = double.Parse(item.Substring(1, item.Length - 2));
                var firstLetter = item[0];
                var lastLetter = item[item.Length - 1];
              

                if (char.IsUpper(firstLetter))
                {
                    num /= (firstLetter - 'A' + 1);
                }
                else
                {
                    num *=(firstLetter - 'a' + 1);
                }

                if (char.IsUpper(lastLetter))
                {
                    num -= (lastLetter - 'A' + 1);
                }
                else
                {
                    num += (lastLetter - 'a' + 1);
                }

                sum += num;
            }

            Console.WriteLine($"{sum:F2}");
        }
    }
}
