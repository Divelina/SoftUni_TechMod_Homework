using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_LongerLine
{
    public class LongerLine
    {
        public static void Main()
        {
            var x1Line1 = double.Parse(Console.ReadLine());
            var y1Line1 = double.Parse(Console.ReadLine());
            var x2Line1 = double.Parse(Console.ReadLine());
            var y2Line1 = double.Parse(Console.ReadLine());

            var lengthLine1 = LineLength(x1Line1, y1Line1, x2Line1, y2Line1);

            var x1Line2 = double.Parse(Console.ReadLine());
            var y1Line2 = double.Parse(Console.ReadLine());
            var x2Line2 = double.Parse(Console.ReadLine());
            var y2Line2 = double.Parse(Console.ReadLine());

            var lengthLine2 = LineLength(x1Line2, y1Line2, x2Line2, y2Line2);

            var output = string.Empty;

            if (lengthLine1 >= lengthLine2)
            {
                output = EndCoordsLine(x1Line1, y1Line1, x2Line1, y2Line1);
            }
            else
            {
                output = EndCoordsLine(x1Line2, y1Line2, x2Line2, y2Line2);
            }

            Console.WriteLine(output);
        }

        public static double LineLength(double x1Line1, double y1Line1, double x2Line1, double y2Line1)
        {
            var length = (x2Line1 - x1Line1) * (x2Line1 - x1Line1) + (y2Line1 - y1Line1) * (y2Line1 - y1Line1);
            length = Math.Sqrt(length);

            return length;
        }

        public static double DistanceToOrigin(double x1, double y1)
        {
            return Math.Sqrt(x1 * x1 + y1 * y1);
        }


        public static string EndCoordsLine(double x1, double y1, double x2, double y2)
        {
            var result = $"({x1}, {y1})";
            if (DistanceToOrigin(x1, y1) <= DistanceToOrigin(x2, y2))
            {
                result += $"({x2}, {y2})";
            }
            else
            {
                result = $"({x2}, {y2})" + result;
            }

            return result;
        }
    }

    
}
