using System;

namespace _13_GameOfNumbers
{
    public class GameOfNums
    {
        public static void Main()
        {
            var min = int.Parse(Console.ReadLine());
            var max = int.Parse(Console.ReadLine());
            var magicNm = int.Parse(Console.ReadLine());

            var isMagicFound = false;
            var totalCombinations = (max - min + 1) * (max - min + 1);

            for (int i = max; i >= min; i--)
            {
                for (int j = max; j >= min; j--)
                {
                    if ((i + j) == magicNm)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magicNm}");
                        isMagicFound = true;
                        break;
                    }
                }

                if (isMagicFound)
                {
                    break;
                }
            }

            if (!isMagicFound)
            {
                Console.WriteLine($"{totalCombinations} combinations - neither equals {magicNm}");
            }

        }
    }
}
