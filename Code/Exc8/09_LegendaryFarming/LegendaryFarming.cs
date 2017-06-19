using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_LegendaryFarming
{
    public class LegendaryFarming
    {
        public static void Main()
        {
            var treasure = new Dictionary<string, int>();
            var junk = new Dictionary<string, int>();

            treasure["shards"] = 0;
            treasure["motes"] = 0;
            treasure["fragments"] = 0;
            //var maxTreas = treasure.Max(item => item.Value);

            while (true)
             {
                var loot = Console.ReadLine().Split(' ').ToList();

                for (int i = 0; i < loot.Count; i+=2)
                {
                    var name = loot[i + 1].ToLower() ;
                    var num = int.Parse(loot[i]);

                    if (name == "shards" || name == "motes" || name == "fragments")
                    {
                        treasure[name] += num;
                        if (treasure[name] >= 250)
                        {
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(name))
                        {
                            junk[name] = 0;
                        }
                        junk[name] += num;
                    }
                }

               var maxTreas = treasure.Max(item => item.Value);

                if (maxTreas >= 250)
                {
                    break;
                }
            }

            var maxTreasureName =  treasure.Single( item => item.Value >= 250).Key.ToString();

            treasure[maxTreasureName] -= 250;

            var itemWon = string.Empty;

            switch (maxTreasureName)
            {
                case "shards":
                    itemWon = "Shadowmourne"; break;
                case "fragments":
                    itemWon = "Valanyr"; break;
                case "motes":
                    itemWon = "Dragonwrath";break;
            }

            Console.WriteLine($"{itemWon} obtained!");

            treasure = treasure
                .OrderByDescending(item => item.Value)
                .ThenBy(item => item.Key)
                .ToDictionary(item => item.Key, item => item.Value);
            
            foreach (var item in treasure)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            if (junk.Count > 0)
            {
                junk = junk
                    .OrderBy(item => item.Key)
                    .ToDictionary(item => item.Key, item => item.Value);

                foreach (var item in junk)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }
    }
}
