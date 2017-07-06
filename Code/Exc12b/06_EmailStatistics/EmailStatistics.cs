using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06_EmailStatistics
{
    public class EmailStatistics
    {
        public static void Main()
        {
            var lineNum = int.Parse(Console.ReadLine());
            var domainUsernames = new Dictionary<string, HashSet<string>>();

            var pattern = @"^([a-zA-Z]{5,})@([a-zA-Z]{3,}(?:\.com|\.bg|\.org))$";
            var emailRegex = new Regex(pattern);

            for (int i = 1; i <= lineNum; i++)
            {
                var nextEmail = Console.ReadLine();

                if (emailRegex.IsMatch(nextEmail))
                {
                    var user = emailRegex.Match(nextEmail).Groups[1].ToString();
                    var domain = emailRegex.Match(nextEmail).Groups[2].ToString();

                    if (!domainUsernames.ContainsKey(domain))
                    {
                        domainUsernames[domain] = new HashSet<string>();
                    }

                    domainUsernames[domain].Add(user);
                }
            }

            domainUsernames = domainUsernames
                .OrderByDescending(kvp => kvp.Value.Count())
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);

            foreach (var kvp in domainUsernames)
            {
                Console.WriteLine($"{kvp.Key}:");

                foreach (var name in kvp.Value)
                {
                    Console.WriteLine($"### {name}");
                }
            }
        }
    }
}
