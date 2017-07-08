using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03_FootballLeagues
{
    public class Standing
    {
        public int Points { get; set; }
        public int Goals { get; set; }
    }

    public class FootballLeague
    {
        public static void Main()
        {
            var key = Console.ReadLine();
            var teamStanding = new Dictionary<string, Standing>();

            var derby = Console.ReadLine();

            while (derby != "final")
            {
                var splitLine = derby
                    .Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var team1 = FindTeam(splitLine[0], key);
                var team2 = FindTeam(splitLine[1], key);
                var goalsTeam1 = int.Parse(splitLine[2]);
                var goalsTeam2 = int.Parse(splitLine[3]);

                if (!teamStanding.ContainsKey(team1))
                {
                    teamStanding[team1] = new Standing()
                    {
                        Points = 0,
                        Goals = 0
                    };
                }

                teamStanding[team1].Goals += goalsTeam1;

                if (!teamStanding.ContainsKey(team2))
                {
                    teamStanding[team2] = new Standing()
                    {
                        Points = 0,
                        Goals = 0
                    };
                }

                teamStanding[team2].Goals += goalsTeam2;

                if (goalsTeam1 > goalsTeam2)
                {
                    teamStanding[team1].Points += 3;
                }
                else if (goalsTeam1 < goalsTeam2)
                {
                    teamStanding[team2].Points += 3;
                }
                else
                {
                    teamStanding[team1].Points++;
                    teamStanding[team2].Points++;
                }

                derby = Console.ReadLine();
            }

            teamStanding = teamStanding
                .OrderByDescending(t => t.Value.Points)
                .ThenBy(t => t.Key)
                .ToDictionary(t => t.Key, t => t.Value);

            var mostGoals = teamStanding
                .OrderByDescending(t => t.Value.Goals)
                .ThenBy(t => t.Key)
                .Take(3)
                .ToDictionary(t => t.Key, t => t.Value);

            Console.WriteLine("League standings:");

            var i = 0;

            foreach (var team in teamStanding)
            {
                i++;
                Console.WriteLine($"{i}. {team.Key} {team.Value.Points}");
            }

            Console.WriteLine($"Top 3 scored goals:");

            foreach (var team in mostGoals)
            {
                Console.WriteLine($"- {team.Key} -> {team.Value.Goals}");
            }
        }

        public static string FindTeam(string v, string k)
        {
            var startIndex = v.IndexOf(k) + k.Length;
            var endIndex = v.LastIndexOf(k);

            var teamStr = v.Substring(startIndex, endIndex - startIndex);
            var teamName = string.Empty;

            for (int i = teamStr.Length -1; i >= 0; i--)
            {
                teamName += teamStr[i];
            }
            
            return teamName.ToUpper();   
        }
    }
}
