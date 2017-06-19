using System;
using System.Collections.Generic;
using System.Linq;


namespace _11_DragonArmy
{
    public class DragonArmy
    {
        public static void Main()
        {
            var dragonStats = new Dictionary<string, SortedDictionary<string, List<int>>>();
            var num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                var entry = Console.ReadLine().Split(' ').ToArray();

                var type = entry[0];
                var name = entry[1];
                var damage = 0;
                var health = 0;
                var armor = 0;

                if (entry[2] == "null")
                {
                    damage = 45;
                }
                else
                {
                    damage = int.Parse(entry[2]);
                }

                if (entry[3] == "null")
                {
                    health = 250;
                }
                else
                {
                    health = int.Parse(entry[3]);
                }

                if (entry[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = int.Parse(entry[4]);
                }

                if (!dragonStats.ContainsKey(type))
                {
                    dragonStats[type] = new SortedDictionary<string, List<int>>();
                }

                if (!dragonStats[type].ContainsKey(name))
                {
                    dragonStats[type][name] = new List<int>();
                }
                else
                {
                    dragonStats[type][name].Clear();
                }
                
                dragonStats[type][name].Add(damage);
                dragonStats[type][name].Add(health);
                dragonStats[type][name].Add(armor);
            }

            foreach (var dragonType in dragonStats)
            {
                var avgDamage = dragonType
                    .Value
                    .Values
                    .Average(x => x.First(st => st >= 0));
                var avgHealth= dragonType
                    .Value
                    .Values
                    .Average(x => x.Skip(1).First(st => st >= 0));
                var avgaArmor = dragonType
                    .Value
                    .Values
                    .Average(x => x.Skip(2).First(st => st >= 0));

                Console.WriteLine($"{dragonType.Key}::({avgDamage:F2}/{avgHealth:F2}/{avgaArmor:F2})");

                foreach (var dragon in dragonType.Value)
                {
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                }
            }
        }
    }
}
