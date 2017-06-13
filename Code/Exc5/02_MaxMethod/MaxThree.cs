using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MaxMethod
{
    public class MaxThree
    {
        public static void Main()
        {
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            var thirdNum = int.Parse(Console.ReadLine());

            var maxFirstSecond = GetMax(firstNum, secondNum);
            var max = GetMax(maxFirstSecond, thirdNum);

            Console.WriteLine(max);
        }

        public static int GetMax(int firstNum, int secondNum)
        {
            if (firstNum >= secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
        }
    }
}
