using System;
using System.Linq;

namespace SampleExam1
{
    public class SinoTheWalker
    {
        public static void Main()
        {
            var startTime = Console.ReadLine()
                .Split(':')
                .Select(ulong.Parse)
                .ToArray();

            var stepNum = ulong.Parse(Console.ReadLine());
            var stepTime = ulong.Parse(Console.ReadLine());
            
            //calculating the movement time in seconds
            ulong movementTime = stepNum * stepTime;

            //calculating the seconds; converting the left time to minutes
            var seconds = (movementTime + startTime[2]) % 60;
            movementTime = (movementTime + startTime[2]) / 60;

            //calculating the minutes; converting the left time in hours
            var minutes = (movementTime + startTime[1]) % 60;
            movementTime = (movementTime + startTime[1]) / 60;

            var hours = (movementTime + startTime[0]) % 24;

            var strSeconds = seconds.ToString();
            var strMinutes = minutes.ToString();
            var strHours = hours.ToString();

           if (seconds < 10)
           {
                strSeconds = "0" + strSeconds;
           }

           if (minutes < 10)
           {
                strMinutes = "0" + strMinutes;
           }

           if (hours < 10)
           {
                strHours = "0" + strHours;
           }

            Console.WriteLine($"Time Arrival: {strHours}:{strMinutes}:{strSeconds}");
        }
    }
}
