using System;
using System.Collections.Generic;
using System.Linq;

namespace _06_UserLogs
{
    public class UserLogs
    {
        public static void Main()
        {
            var userIPMsg = new SortedDictionary<string, Dictionary<string, int>>();

            var line = Console.ReadLine();

            while (line != "end")
            {
                var split = line.Split(' ').ToArray();

                var ip = split[0].Substring(3);
                var userName = split[2].Substring(5);

                if (!userIPMsg.ContainsKey(userName))
                {
                    userIPMsg[userName] = new Dictionary<string, int>();
                }

                if (!userIPMsg[userName].ContainsKey(ip))
                {
                    userIPMsg[userName][ip] = 0;
                }

                userIPMsg[userName][ip]++;

                line = Console.ReadLine();
            }

            foreach (var entry in userIPMsg)
            {
                Console.WriteLine($"{entry.Key}:");

                var output = string.Empty;

                foreach (var ipNum in entry.Value)
                {
                    output += $"{ipNum.Key} => {ipNum.Value}, ";
                }

                output = output.TrimEnd().TrimEnd(',') + ".";
                Console.WriteLine(output);
            }
        }
    }
}
