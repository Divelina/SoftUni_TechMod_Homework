using System;

namespace _10_CubeProperties
{
    public class CubeProp
    {
        public static void Main()
        {
            var side = double.Parse(Console.ReadLine());
            var parameterToCalculate = Console.ReadLine();
            var result = 0.0;

            switch (parameterToCalculate)
            {
                case "face":
                    result = FaceDiagonalCube(side); break;
                case "space":
                    result = SpaceDiagonalCube(side); break;
                case "volume":
                    result = VolumeCube(side); break;
                case "area":
                    result = AreaCube(side); break;
            }

            Console.WriteLine($"{result:F2}");
        }

        public static double FaceDiagonalCube(double side)
        {
            return Math.Sqrt(2 * side * side);
        }

        public static double SpaceDiagonalCube(double side)
        {
            return Math.Sqrt(3 * side * side);
        }

        public static double VolumeCube(double side)
        {
            return side * side * side;
        }

        public static double AreaCube(double side)
        {
            return 6 * side * side;
        }
    }
}
