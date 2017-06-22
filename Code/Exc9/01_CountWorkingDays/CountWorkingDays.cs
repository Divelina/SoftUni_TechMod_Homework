using System;
using System.Linq;
using System.Globalization;

namespace _01_CountWorkingDays
{
    public class CountWorkingDays
    {
        public static void Main()
        {
            var first = Console.ReadLine();
            var second = Console.ReadLine();

            var startDate = DateTime.ParseExact(first, "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endtDate = DateTime.ParseExact(second, "dd-MM-yyyy", CultureInfo.InvariantCulture);

            var holidays = new string[]
            {
                "01-01", "03-03", "01-05", "06-05", "24-05", "06-09", "22-09",
                "01-11", "24-12", "25-12", "26-12"
            };

            var countHolidays = 0;
            var countDays = 0;

            for (DateTime i = startDate; i <= endtDate; i = i.AddDays(1))
            {
                countDays++;
                if ((i.DayOfWeek == DayOfWeek.Saturday) || (i.DayOfWeek == DayOfWeek.Sunday))
                {
                    countHolidays++;
                }
                else
                {
                    var dayString = i.Date.ToString("dd-MM");
                    if (holidays.Contains(dayString))
                    {
                        countHolidays++;
                    }
                }
            }

            Console.WriteLine(countDays - countHolidays);
            
        }
    }
}
