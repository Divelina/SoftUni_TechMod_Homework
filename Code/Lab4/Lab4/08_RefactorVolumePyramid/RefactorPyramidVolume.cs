using System;

namespace _08_RefactorVolumePyramid
{
    public class RefactorPyramidVolume
    {
        public static void Main()
        {
            Console.Write("Length: ");
            var length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            var width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            var heigth = double.Parse(Console.ReadLine());

            var volume = (length * width * heigth) / 3;
            Console.WriteLine("Pyramid Volume: {0:F2}", volume);
        }
    }
}
