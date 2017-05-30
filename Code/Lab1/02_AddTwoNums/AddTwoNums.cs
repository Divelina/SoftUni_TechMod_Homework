using System;

namespace _02_AddTwoNums
{
    public class AddTwoNums
    {
        public static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());

            var sum = firstNum + secondNum;

            Console.WriteLine($"{firstNum} + {secondNum} = {sum}");
        }
    }
}
