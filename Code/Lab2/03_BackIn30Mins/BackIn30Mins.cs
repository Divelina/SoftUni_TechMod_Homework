using System;

namespace _03_BackIn30Mins
{
    public class BackIn30Mins
    {
        public static void Main()
        {
            var hours = int.Parse(Console.ReadLine());
            var mins = int.Parse(Console.ReadLine());

            hours += (mins +30) / 60;
            hours %= 24;
            mins = (mins + 30) % 60;

            Console.WriteLine($"{hours}:{mins:00}");
        }
    }
}
