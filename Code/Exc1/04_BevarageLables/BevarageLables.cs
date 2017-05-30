using System;

namespace _04_BevarageLables
{
    public class BevarageLables
    {
        public static void Main()
        {
            var bevarageName = Console.ReadLine();
            //volume in ml
            var volume = double.Parse(Console.ReadLine());
            //energy kcal per 100(!) ml
            var energy = double.Parse(Console.ReadLine());
            //sugar in g per 100(!) ml
            var sugar = double.Parse(Console.ReadLine());

            //calculate total energy and sugar
            var totalEnergy = energy * volume / 100;
            var totalSugar = sugar * volume / 100;

            Console.WriteLine($"{volume}ml {bevarageName}:");
            Console.WriteLine($"{totalEnergy}kcal, {totalSugar}g sugars");
        }
    }
}
