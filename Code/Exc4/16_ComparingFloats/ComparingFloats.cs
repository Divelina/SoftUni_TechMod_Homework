using System;

namespace _16_ComparingFloats
{
    public class ComparingFloats
    {
        public static void Main()
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            double difference = Math.Abs(firstNum - secondNum);

            if (difference >= 0.000001)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
