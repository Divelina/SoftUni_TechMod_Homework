using System;

namespace _09_MultiplicationTable
{
    public class MultiplicationTable
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());
            var product = 0;

            for (int i = 1; i <= 10; i++)
            {
                product = num * i;
                Console.WriteLine($"{num} X {i} = {product}");
            }

            
        }
    }
}
