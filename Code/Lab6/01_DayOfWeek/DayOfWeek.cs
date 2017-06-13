using System;

namespace _01_DayOfWeek
{
    public class DayOfWeek
    {
        public static void Main()
        {
            var num = int.Parse(Console.ReadLine());

            var weekday = new string[]
            {
                "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"
            };

            if ((num >= 1) && (num <=7))
            {
                Console.WriteLine(weekday[num-1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
