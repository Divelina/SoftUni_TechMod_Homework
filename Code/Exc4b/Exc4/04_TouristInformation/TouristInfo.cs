using System;

namespace _04_TouristInformation
{
    public class TouristInfo
    {
        public static void Main()
        {
            var unitName = Console.ReadLine();
            var value = double.Parse(Console.ReadLine());

            var corrUnit = string.Empty;
            var convertedValue = 0.0;

            switch (unitName)
            {
                case "miles":
                    {
                        corrUnit = "kilometers";
                        convertedValue = value * 1.6;
                    }break;
                case "inches":
                    {
                        corrUnit = "centimeters";
                        convertedValue = value * 2.54;
                    }break;
                case "feet":
                    {
                        corrUnit = "centimeters";
                        convertedValue = value * 30;
                    }break;
                case "yards":
                    {
                        corrUnit = "meters";
                        convertedValue = value * 0.91;
                    }break;
                case "gallons":
                    {
                        corrUnit = "liters";
                        convertedValue = value * 3.8;
                    }break;
            }

            Console.WriteLine($"{value} {unitName} = {convertedValue:F2} {corrUnit}");

        }
    }
}
