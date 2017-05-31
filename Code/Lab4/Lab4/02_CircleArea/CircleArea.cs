using System;

namespace _02_CircleArea
{
    public class CircleArea
    {
        public static void Main()
        {
            var radius = double.Parse(Console.ReadLine());

            var area = Math.PI * radius * radius;

            Console.WriteLine($"{area:F12}");
        }
    }
}
