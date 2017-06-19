using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_PhoneBook
{
    public class PhoneBook
    {
        public static void Main()
        {
            var namePhone = new Dictionary<string, string>();

            var line = Console.ReadLine();

            while (line != "END")
            {
                var splitLine = line.Split(' ').ToArray();

                if (splitLine[0] == "A")
                {
                    var name = splitLine[1];
                    var phone = splitLine[2];

                    namePhone[name] = phone;
                }
                else if (splitLine[0] == "S")
                {
                    var name = splitLine[1];

                    if (!namePhone.ContainsKey(name))
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                    else
                    {
                        Console.WriteLine($"{name} -> {namePhone[name]}");
                    }
                }


                line = Console.ReadLine();
            }
        }
    }
}
