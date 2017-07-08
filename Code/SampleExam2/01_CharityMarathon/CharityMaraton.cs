using System;
using System.Numerics;

namespace _01_CharityMarathon
{
    public class CharityMaraton
    {
        public static void Main()
        {
            var days = int.Parse(Console.ReadLine());
            var listedRunners = int.Parse(Console.ReadLine());
            var avrgLaps = int.Parse(Console.ReadLine());
            var trackLength = int.Parse(Console.ReadLine());
            var capacity = int.Parse(Console.ReadLine());
            var moneyPerKm = decimal.Parse(Console.ReadLine());

            var runners = (int)Math.Min(listedRunners, capacity * days);
            decimal trackLenghtKm = (decimal)trackLength / 1000; 

            decimal totalKm = trackLenghtKm * runners * avrgLaps;
            decimal charityMoney = moneyPerKm * totalKm;

            Console.WriteLine($"{charityMoney:F2}");
        }
    }
}
