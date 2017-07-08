using System;
using System.Collections.Generic;
using System.Linq;

namespace _2_SoftUniKaraoke
{
    public class SoftUniKaraoke
    {
        public static void Main()
        {
            var participantAwards = new Dictionary<string, SortedSet<string>>();

            var participants = Console.ReadLine()
                .Split(',')
                .Select(w => w.Trim())
                .ToArray();
            var songs = Console.ReadLine()
                .Split(',')
                .Select(w => w.Trim())
                .ToArray();

            var input = Console.ReadLine();

            while (input != "dawn")
            {
                var splitInput = input
                    .Split(',')
                    .Select(w => w.Trim())
                    .ToArray();
                var singer = splitInput[0];
                var song = splitInput[1];
                var award = splitInput[2];

                if (participants.Contains(singer) && songs.Contains(song))
                {
                    if (!participantAwards.ContainsKey(singer))
                    {
                        participantAwards[singer] = new SortedSet<string>();
                    }
                    participantAwards[singer].Add(award);
                }

                input = Console.ReadLine();
            }

            if (participantAwards.Count > 0)
            {
                var output = participantAwards
                    .OrderByDescending(p => p.Value.Count)
                    .ThenBy(p => p.Key)
                    .ToDictionary(p => p.Key, p => p.Value);

                foreach (var name in output)
                {
                    Console.WriteLine($"{name.Key}: {name.Value.Count} awards");
                    foreach (var prize in name.Value)
                    {
                        Console.WriteLine($"--{prize}");
                    }
                }

            }
            else
            {
                Console.WriteLine("No awards");
            }


        }
    }
}
