using System;


namespace _11_GeometryCalculator
{
    public class GeometryCalc
    {
        public static void Main()
        {
            var figureType = Console.ReadLine().ToLower();
            var area = 0.0;

            switch (figureType)
            {
                case "triangle":
                    {
                        var a = double.Parse(Console.ReadLine());
                        var h = double.Parse(Console.ReadLine());
                        area = TriangleArea(a, h);
                    } break;
                case "square":
                    {
                        var a = double.Parse(Console.ReadLine());
                        area = SquareArea(a);
                    }break;
                case "rectangle":
                    {
                        var a = double.Parse(Console.ReadLine());
                        var b = double.Parse(Console.ReadLine());
                        area = RectangleArea(a, b);
                    }break;
                case "circle":
                    {
                        var r = double.Parse(Console.ReadLine());
                        area = CircleArea(r);
                    }break;
            }

            Console.WriteLine($"{area:F2}");
        }

        public static double CircleArea(double r)
        {
            return Math.PI * r * r;
        }

        public static double RectangleArea(double a, double b)
        {
            return a * b;
        }

        public static double SquareArea(double a)
        {
            return a * a;
        }

        public static double TriangleArea(double a, double h)
        {
            return (a * h) / 2;
        }
    }
}
