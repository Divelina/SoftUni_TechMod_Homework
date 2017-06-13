using System;

namespace _08_CenterPoing
{
    public class CenterPoint
    {
        public static void Main()
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var distance1 = DistanceToOrigin(x1, y1);
            var distance2 = DistanceToOrigin(x2, y2);

            if (distance1 <= distance2)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }

        public static double DistanceToOrigin(double x1, double y1)
        {
            return Math.Sqrt(x1 * x1 + y1 * y1);
        }
    }
}
