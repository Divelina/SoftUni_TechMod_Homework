using System;

namespace _07_SentenceTheThief
{
    public class SentenceTheThief
    {
        public static void Main()
        {
            var numType = Console.ReadLine();
            var inputLines = int.Parse(Console.ReadLine());
            var thiefID = -1L;

            long maxValue = sbyte.MaxValue;

            switch (numType)
            {
                case "sbyte":
                    {
                        maxValue = sbyte.MaxValue;
                     }
                    break;
                case "int":
                    {
                        maxValue = int.MaxValue;
                     }
                    break;
                case "long":
                    {
                        maxValue = long.MaxValue;
                     }
                    break;
            }

            var minDifferece = long.MaxValue;

            for (int i = 1; i <= inputLines; i++)
            {
                var id = long.Parse(Console.ReadLine());
                var diff = maxValue - id;

                if ((diff >= 0) && (diff < minDifferece))
                {
                    minDifferece = diff;
                    thiefID = id;
                }
            }

            long sentence;
            if (thiefID > 0)
            {
                sentence = thiefID / sbyte.MaxValue + 1;
            }
            else
            {
                sentence = thiefID / sbyte.MinValue + 1;
            }

            if (sentence == 1)
            {
                Console.WriteLine($"Prisoner with id {thiefID} is sentenced to {sentence} year");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {thiefID} is sentenced to {sentence} years");
            }
        }
    }
}
