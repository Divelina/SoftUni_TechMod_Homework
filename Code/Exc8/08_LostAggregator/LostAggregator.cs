using System;
using System.Collections.Generic;
using System.Linq;

namespace _08_LostAggregator
{
    public class LostAggregator
    {
        public static void Main()
        {
            var userDuration = new SortedDictionary<string, int>();
            var userIPs = new SortedDictionary<string, SortedSet<string>>();
            var lineNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= lineNum; i++)
            {
                var line = Console.ReadLine();
                var split = line.Split(' ').ToArray();

                var ip = split[0];
                var user = split[1];
                var duration = int.Parse(split[2]);

                if (!userDuration.ContainsKey(user))
                {
                    userDuration[user] = 0;
                    userIPs[user] = new SortedSet<string>();
                }

                userDuration[user] += duration;
                userIPs[user].Add(ip);
            }

            foreach (var person in userIPs)
            {
                var ipList = String.Join(", ", person.Value);
                Console.WriteLine($"{person.Key}: {userDuration[person.Key]} [{ipList}]");
            }
        }
    }
}
