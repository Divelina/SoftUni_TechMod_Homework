using System;

namespace _11_ConvertSpeedUnits
{
    public class ConvertSpeedUnits
    {
        public static void Main(string[] args)
        {
            var distanceInMeters = float.Parse(Console.ReadLine());
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            var seconds = int.Parse(Console.ReadLine());
            var totalSeconds = seconds + 60 * minutes + 3600 * hours;

            var speedInMetersPerSec = (distanceInMeters / (totalSeconds));
            var speedInKmPerHour = ((distanceInMeters / 1000) / (totalSeconds / 3600.0f));
            var speedInMilesPerHour = (speedInKmPerHour / 1.609f);

            Console.WriteLine($"{speedInMetersPerSec}");
            Console.WriteLine($"{speedInKmPerHour}");
            Console.WriteLine($"{speedInMilesPerHour}");

        }
    }
}
