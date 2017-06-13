using System;

namespace _06_CatchTheThief
{
    public class CatchTheThief
    {
        public static void Main()
        {
            var numType = Console.ReadLine();
            var inputLines = int.Parse(Console.ReadLine());

            var maxValue = long.MinValue;
            var thiefID = -1L;
            
            switch (numType)
            {
                case "sbyte":
                    {
                        maxValue = sbyte.MaxValue;
                    }break;
                case "int":
                    {
                        maxValue = int.MaxValue;
                    }break;
                case "long":
                    {
                        maxValue = long.MaxValue;
                    }break;
            }

            var minDifferece = long.MaxValue;

            for (int i = 1; i <= inputLines; i++)
            {
                var id = long.Parse(Console.ReadLine());
                var diff = maxValue - id;

                if ((diff >=0) && (diff < minDifferece))
                {
                    minDifferece = diff;
                    thiefID = id;
                }
            }

            Console.WriteLine(thiefID);
        }
    }
}
