using System;

namespace _05_WeatherForecast
{
    public class WeatherForecast
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            sbyte res1;
            int res2;
            long res3;
            decimal res4;

            if (sbyte.TryParse(input, out res1))
            {
                Console.WriteLine("Sunny");
            }
            else if (int.TryParse(input, out res2))
            {
                Console.WriteLine("Cloudy");
            }
            else if (long.TryParse(input, out res3))
            {
                Console.WriteLine("Windy");
            }
            else if (decimal.TryParse(input, out res4))
            {
                Console.WriteLine("Rainy");
            }
        }
    }
}
