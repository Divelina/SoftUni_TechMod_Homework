using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace _03_CameraView
{
    public class CameraView
    {
        public static void Main()
        {
            var nums = Console.ReadLine().Split(' ').ToArray();

            var skip = nums[0];
            var take = nums[1];

            var pattern = @"\|<[^\|]{" + skip + @"}([^\|]{1," + take + @"})";
            var cameraRegex = new Regex(pattern);

            var inputLine = Console.ReadLine();
            MatchCollection cameraViews = cameraRegex.Matches(inputLine);

            var views = new List<string>();

            foreach (Match match in cameraViews)
            {
                var current = match.Groups[1].ToString();
                views.Add(current);
            }

            Console.WriteLine(String.Join(", ", views));
        }
    }
}
