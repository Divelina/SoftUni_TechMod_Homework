using System;

namespace _19_TheaPhoto_Exam_11Sept16
{
    public class TheaThePhotographer
    {
        public static void Main()
        {
            var picturesNum = int.Parse(Console.ReadLine());
            var filterSecsPerPic = int.Parse(Console.ReadLine());
            var percentFiltered = int.Parse(Console.ReadLine());
            var uploadSecsPerPic = int.Parse(Console.ReadLine());

            long totalSecs = (long)picturesNum * filterSecsPerPic;
            totalSecs += (long)(Math.Ceiling((long)picturesNum * percentFiltered / 100.0m)) * uploadSecsPerPic;

            var days = totalSecs / (60 * 60 * 24);
            var secondsLeft = totalSecs % (60 * 60 * 24);
            var hours = secondsLeft / (60 * 60);
            secondsLeft = secondsLeft % (60 * 60);
            var minutes = secondsLeft / 60;
            secondsLeft = secondsLeft % 60;

            //Console.WriteLine(totalSecs);
            Console.WriteLine($"{days}:{hours:00}:{minutes:00}:{secondsLeft:00}");
        }
    }
}
