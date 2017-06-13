using System;

namespace _03_waterOverflow
{
    public class WaterOverflow
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var tankFilled = 0;

            for (int i = 1; i <= num ; i++)
            {
                var nextQuantity = int.Parse(Console.ReadLine());

                if (tankFilled + nextQuantity > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    tankFilled += nextQuantity;
                }
            }

            Console.WriteLine(tankFilled);
        }
    }
}
