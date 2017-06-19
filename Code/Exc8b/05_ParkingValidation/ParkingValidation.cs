using System;
using System.Collections.Generic;
using System.Linq;

namespace _05_ParkingValidation
{
    public class ParkingValidation
    {
        public static void Main()
        {
            var userPlates = new Dictionary<string, string>();

            var lineNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < lineNum; i++)
            {
                var command = Console.ReadLine().Split(' ').ToList();

                if (command[0] == "register")
                {
                    var userName = command[1];
                    var plateNum = command[2];

                    if (userPlates.ContainsKey(userName))
                    {
                        if (userPlates[userName] != plateNum)
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {userPlates[userName]}");
                        }
                    }
                    else if (!ValidatePlate(plateNum))
                    {
                        Console.WriteLine($"ERROR: invalid license plate {plateNum}"); ;
                    }
                    else if (userPlates.ContainsValue(plateNum))
                    {
                        Console.WriteLine($"ERROR: license plate {plateNum} is busy");
                    }
                    else
                    {
                        userPlates[userName] = plateNum;
                        Console.WriteLine($"{userName} registered {plateNum} successfully");
                    }
                }
                else if (command[0] == "unregister")
                {
                    var userName = command[1];

                    if (!userPlates.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                    else
                    {
                        userPlates.Remove(userName);
                        Console.WriteLine($"user {userName} unregistered successfully");
                    }
                }
            }

            foreach (var user in userPlates)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }

        public static bool ValidatePlate(string plateNum)
        {
            var mid = plateNum.Substring(2, 4);

            var isValid = (plateNum.Length == 8) &&
                plateNum[0] >= 'A' && plateNum[0] <= 'Z' &&
                plateNum[1] >= 'A' && plateNum[1] <= 'Z' &&
                plateNum[plateNum.Length -1] >= 'A' && plateNum[plateNum.Length - 1] <= 'Z' &&
                plateNum[plateNum.Length - 2] >= 'A' && plateNum[plateNum.Length - 2] <= 'Z' &&
                mid.CompareTo("0000") >= 0 && mid.CompareTo("9999") <= 0;

            return isValid;
        }
    }
}
