using System;
using System.Globalization;

namespace _04_PhotoGallery
{
    public class PhotoGallery
    {
        public static void Main()
        {
            var photoNum = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hour = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());
            var bytes = int.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            var fileName = $"DSC_{photoNum:D4}.jpg";
            var fullDate = new DateTime(year, month, day, hour, minute, 0);
            var printDate = fullDate.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            var convertBytes = string.Empty;

            if (bytes < 1000)
            {
                convertBytes = bytes + "B";
            }
            else if (bytes < 1000000)
            {
                convertBytes = (1.0 * bytes / 1000) + "KB";
            }
            else
            {
                convertBytes = (1.0 * bytes / 1000000) + "MB";
            }

            var orientation = string.Empty;

            if (width > height)
            {
                orientation = "landscape";
            }
            else if (width < height)
            {
                orientation = "portrait";
            }
            else
            {
                orientation = "square";
            }

            Console.WriteLine($"Name: {fileName}");
            Console.WriteLine($"Date Taken: {printDate}");
            Console.WriteLine($"Size: {convertBytes}");
            Console.WriteLine($"Resolution: {width}x{height} ({orientation})");
        }
    }
}
