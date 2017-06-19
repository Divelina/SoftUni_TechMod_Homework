using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_AMinerTask
{
    public class AMinerTask
    {
        public static void Main()
        {
            var resources = new Dictionary<string, int>();
            var line = Console.ReadLine();

            while (line != "stop")
            {
                var quant = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(line))
                {
                    resources[line] = 0;
                }
                resources[line] += quant;

                line = Console.ReadLine();
            }

            foreach(var entry in resources)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }
    }
}
