using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_PhoneBookUpgrad
{
    public class PhoneBookUpgrade
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
                else if (splitLine[0]=="ListAll")
                {
                   var  output = namePhone.OrderBy(e => e.Key)
                        .ToDictionary(e => e.Key, e => e.Value);

                    foreach(var entry in output)
                    {
                        Console.WriteLine($"{entry.Key} -> {entry.Value}");
                    }
                }
            

                line = Console.ReadLine();
            }
        }
    }
}
