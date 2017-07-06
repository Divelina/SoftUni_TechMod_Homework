using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_VehicleCatalogue
{
    public class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }

    public class VehicleCatalogue
    {
        public static void Main()
        {
            var cars = new List<Vehicle>();
            var trucks = new List<Vehicle>();

            var input = Console.ReadLine();

            while (input != "End")
            {
                var splitLine = input.Split(' ').ToArray();

                var type = splitLine[0].ToLower();
                var model = splitLine[1];
                var color = splitLine[2];
                var horsePower = int.Parse(splitLine[3]);

                var nextVehicle = new Vehicle
                {
                    Type = type,
                    Model =model,
                    Color = color,
                    HorsePower = horsePower
                };

                if (nextVehicle.Type == "car")
                {
                    nextVehicle.Type = "Car";
                    cars.Add(nextVehicle);
                }
                else if (nextVehicle.Type == "truck")
                {
                    nextVehicle.Type = "Truck";
                    trucks.Add(nextVehicle);
                }

                input = Console.ReadLine();
            }

            var output = Console.ReadLine();
            while (output != "Close the Catalogue")
            {
                var theVehicle = cars
                    .FirstOrDefault(c => c.Model == output);

                if (theVehicle == null)
                {
                    theVehicle = trucks
                        .FirstOrDefault(t => t.Model == output);                       
                }

                if (theVehicle != null)
                {
                    Console.WriteLine($"Type: {theVehicle.Type}");
                    Console.WriteLine($"Model: {theVehicle.Model}");
                    Console.WriteLine($"Color: {theVehicle.Color}");
                    Console.WriteLine($"Horsepower: {theVehicle.HorsePower}");
                }

                output = Console.ReadLine();
            }

            var carHP = 0.0;
            var truckHP = 0.0;

            if (cars.Count > 0)
            {
                carHP = cars.Average(c => c.HorsePower);
            }

            if (trucks.Count > 0)
            {
                truckHP = trucks.Average(t => t.HorsePower);
            }

            Console.WriteLine($"Cars have average horsepower of: {carHP:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckHP:F2}.");
        }
    }
}
