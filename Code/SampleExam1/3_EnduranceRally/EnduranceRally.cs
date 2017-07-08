using System;
using System.Collections.Generic;
using System.Linq;

namespace _3_EnduranceRally
{
    public class EnduranceRally
    {
        public static void Main()
        {
            var driversFuel = new Dictionary<string, decimal>();

            var drivers = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var stations = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToArray();

            var chargeStationIndexes = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (var name in drivers)
            {
                driversFuel[name] = 1.0m * (int)name[0];
                bool isFinished = true;

                for (int i = 0; i < stations.Length; i++)
                {
                    if (chargeStationIndexes.Contains(i))
                    {
                        driversFuel[name] += stations[i];
                    }
                    else
                    {
                        driversFuel[name] -= stations[i];
                    }

                    if (driversFuel[name] <= 0)
                    {
                        Console.WriteLine($"{name} - reached {i}");
                        isFinished = false;
                        break;
                    }
                }

                if (isFinished)
                {
                    Console.WriteLine($"{name} - fuel left {driversFuel[name]:F2}");
                }
            }

        }
    }
}
