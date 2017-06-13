using System;

namespace _12_BeerKegs
{
    public class BeerKegs
    {
        public static void Main()
        {
            var numKegs = int.Parse(Console.ReadLine());
            var maxVolume = 0.0;
            var biggestKegModel = string.Empty;

            for (int i = 1; i <= numKegs; i++)
            {
                var model = Console.ReadLine();
                var radius = double.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());

                double volume = Math.PI * radius * radius * height;

                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    biggestKegModel = model;
                }
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}
