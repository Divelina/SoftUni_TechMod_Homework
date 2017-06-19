using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_ImmuneSystem
{
    public class ImmuneSystem
    {
        public static void Main()
        {
            var initialImmuneSysStr = double.Parse(Console.ReadLine());
            var immuneSysStr = initialImmuneSysStr;
            var viruses = new Dictionary<string, int>();

            var nextVirus = Console.ReadLine();

            while (nextVirus != "end")
            {
                var strength = 0;
                var defeatTime = 0;

                if (viruses.ContainsKey(nextVirus))
                {
                    strength = viruses[nextVirus];
                    defeatTime = (strength * nextVirus.Length) / 3;
                }
                else
                {
                    strength = nextVirus.Sum(l => (int)l) / 3;
                    defeatTime = strength * nextVirus.Length;
                    viruses[nextVirus] = strength;
                }

                Console.WriteLine($"Virus {nextVirus}: {strength} => {defeatTime} seconds");

                if (immuneSysStr >= defeatTime)
                {
                    immuneSysStr -= defeatTime;
                    immuneSysStr = Math.Floor(immuneSysStr);
                }
                else
                {
                    Console.WriteLine($"Immune System Defeated.");
                    break;
                }

                var defeatTimeMinSec = $"{(int)defeatTime/ 60}m {(int)defeatTime % 60}s";
                Console.WriteLine($"{nextVirus} defeated in {defeatTimeMinSec}.");
                Console.WriteLine($"Remaining health: {immuneSysStr:F0}");

                if (immuneSysStr * 1.2 > initialImmuneSysStr)
                {
                    immuneSysStr = initialImmuneSysStr;
                }
                else
                {
                    immuneSysStr = Math.Floor(1.2*immuneSysStr);
                }
               
                nextVirus = Console.ReadLine();
            }

            if (nextVirus == "end")
            {
                Console.WriteLine($"Final Health: {immuneSysStr}");
            }
        }
    }
}
