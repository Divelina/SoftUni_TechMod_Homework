using System;

namespace _01_CenturiesToMinutes
{
    public class CenturiesToMinutes
    {
        public static void Main()
        {
            var centuries = int.Parse(Console.ReadLine());
            var years = centuries * 100;
            var days = (long)(years * 365.2422);
            //var hours = (long) (years * 364.2422 * 24);
            //var minutes = (long) (years * 364.2422 * 24 * 60);
            var hours = (days * 24);
            var minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days =  {hours} hours = {minutes} minutes");
        }
    }
}
