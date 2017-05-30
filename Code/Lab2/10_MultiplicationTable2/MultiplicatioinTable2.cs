using System;

namespace _10_MultiplicationTable2
{
    public class MultiplicatioinTable2
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());
            var product = 0;

            if (multiplier >=10)
            {
                product = num * multiplier;
                Console.WriteLine($"{num} X {multiplier} = {product}");
            }
            else
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    product = num * i;
                    Console.WriteLine($"{num} X {i} = {product}");
                }
            }
        }
    }
}
