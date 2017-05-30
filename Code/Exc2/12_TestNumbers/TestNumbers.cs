using System;

namespace _12_TestNumbers
{
    public class TestNumbers
    {
        public static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var sumLimit = int.Parse(Console.ReadLine());

            var accumulatedSum = 0;
            var countCombinations = 0;
            var isReached = false;

            for (int i = firstNum; i >= 1; i--)
            {
                for (int j = 1; j <= secondNum; j++)
                {
                    accumulatedSum += i * j * 3;
                    countCombinations++;
                    
                    if (accumulatedSum >= sumLimit)
                    {
                        isReached = true;
                        break;
                    }
                }

                if (isReached)
                {
                    break;
                }
            }

            Console.WriteLine($"{countCombinations} combinations");


            if (isReached)
            {
                Console.WriteLine($"Sum: {accumulatedSum} >= {sumLimit}");
            }
            else
            {
                Console.WriteLine($"Sum: {accumulatedSum}");
            }
        }
    }
}
