using System;

namespace BMPCounter
{
    public class BMPCounter
    {
        public static void Main()
        {
            var beatsPerMinute = int.Parse(Console.ReadLine());
            var beatsNum = int.Parse(Console.ReadLine());

            var bars = Math.Round(beatsNum / 4.0, 1);

            var seconds = (60.0 * beatsNum) / beatsPerMinute;
            var minutes = (int) seconds / 60;
            var roundedSecons = (int)seconds % 60;

            Console.WriteLine($"{bars} bars - {minutes}m {roundedSecons}s");
        }
    }
}
