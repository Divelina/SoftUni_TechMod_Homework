using System;

namespace _02_RectangleArea
{
    public class RectangleArea
    {
        public static void Main()
        {
            var rectWidth = double.Parse(Console.ReadLine());
            var rectHeight = double.Parse(Console.ReadLine());

            var area = rectHeight * rectWidth;

            Console.WriteLine($"{area:F2}");
        }
    }
}
