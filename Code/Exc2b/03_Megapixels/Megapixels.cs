using System;

namespace _03_Megapixels
{
    public class Megapixels
    {
        public static void Main()
        {
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            var megapix = Math.Round(1.0 * width * height / 1000000, 1);

            Console.WriteLine($"{width}x{height} => {megapix}MP");
        }
    }
}
