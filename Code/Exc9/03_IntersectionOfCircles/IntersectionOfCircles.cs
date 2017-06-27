using System;
using System.Linq;

namespace _03_IntersectionOfCircles
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; } 
    }

    public class Circle
    {
        public Point Center { get; set; }
        public double Radius { get; set; }
    }

    public class IntersectionOfCircles
    {
        public static void Main()
        {
            var firstCircle = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var secondCircle = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            var center1 = CreatePoint(firstCircle[0], firstCircle[1]);
            var circle1 = CreateCircle(center1, firstCircle[2]);
            var center2 = CreatePoint(secondCircle[0], secondCircle[1]);
            var circle2 = CreateCircle(center2, secondCircle[2]);

            if (Intersect(circle1, circle2))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }

        public static Circle CreateCircle(Point center, double r)
        {
            var newCircle = new Circle
            {
                Center = center,
                Radius = r
            };

            return newCircle;
        }

        public static Point CreatePoint(double v1, double v2)
        {
            var newPoint = new Point
            {
                X = v1,
                Y = v2
            };

            return newPoint;
        }

        public static bool Intersect(Circle c1, Circle c2)
        {
            var centerDistance = (c1.Center.X - c2.Center.X) * (c1.Center.X - c2.Center.X)
                + (c1.Center.Y - c2.Center.Y) * (c1.Center.Y - c2.Center.Y);

            centerDistance = Math.Sqrt(centerDistance);

            if (centerDistance > c1.Radius + c2.Radius)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
