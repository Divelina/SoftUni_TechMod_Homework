using System;

namespace _11_FiveDiffNums
{
    public class FiveDiffNums
    {
        public static void Main()
        {
            var firstBorder = int.Parse(Console.ReadLine());
            var secondBorder = int.Parse(Console.ReadLine());

            if (firstBorder <= secondBorder - 4)
            {
                for (int i = firstBorder; i <= secondBorder - 4; i++)
                {
                    for (int j = i + 1; j <= secondBorder - 3; j++)
                    {
                        for (int k = j + 1; k <= secondBorder - 2; k++)
                        {
                            for (int  l = k + 1;  l <= secondBorder - 1;  l++)
                            {
                                for (int m = l + 1; m <= secondBorder; m++)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine($"No");
            }
        }
    }
}
