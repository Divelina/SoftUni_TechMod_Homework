using System;

namespace _10_CenturiesToNanoSecs
{
    public class CenturiesToNanoSecs
    {
        public static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());

            ulong years = (ulong)(100 * centuries);
            ulong days = (ulong)Math.Floor(years * 365.2422);
            ulong hours = days * 24;
            ulong minutes = hours * 60;
            ulong seconds = minutes * 60;
            ulong milliseconds = seconds * 1000;
            decimal microseconds = (decimal)milliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");

        }
    }
}
