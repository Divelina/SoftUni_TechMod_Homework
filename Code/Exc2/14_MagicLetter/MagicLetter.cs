using System;

namespace _14_MagicLetter
{
    public class MagicLetter
    {
        public static void Main()
        {
            var firstBorder = char.Parse(Console.ReadLine());
            var secondBorder = char.Parse(Console.ReadLine());
            var forbiddenLeter = char.Parse(Console.ReadLine());

            for (char ch1 = firstBorder; ch1 <= secondBorder; ch1++)
            {
                if (ch1 == forbiddenLeter)
                {
                    continue;
                }
                for (char ch2 = firstBorder; ch2 <= secondBorder; ch2++)
                {
                    if (ch2 == forbiddenLeter)
                    {
                        continue;
                    }
                    for (char ch3 = firstBorder; ch3 <= secondBorder; ch3++)
                    {
                      if (ch3 == forbiddenLeter)
                        {
                            continue;
                        }
                        Console.Write($"{ch1}{ch2}{ch3} ");
                    }
                }
            }
        }
    }
}
