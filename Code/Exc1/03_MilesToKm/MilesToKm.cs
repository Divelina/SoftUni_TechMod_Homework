using System;

namespace _03_MilesToKm
{
    public class MilesToKm
    {
        public static void Main()
        {
            var miles = double.Parse(Console.ReadLine());

            var kilometers = 1.60934 * miles;

            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
