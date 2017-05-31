using System;

namespace Elevator
{
    public class Elevator
    {
        public static void Main()
        {
            var peopleNum = int.Parse(Console.ReadLine());
            var elevatorCapacity = int.Parse(Console.ReadLine());

            var parts = Math.Ceiling(1.0 * peopleNum / elevatorCapacity);

            Console.WriteLine(parts);
        }
    }
}
