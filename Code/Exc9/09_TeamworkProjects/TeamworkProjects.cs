using System;
using System.Collections.Generic;
using System.Linq;


namespace _09_TeamworkProjects
{
    public class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public SortedSet<string> Members { get; set; }
    }

    public class TeamworkProjects
    {
        public static void Main()
        {
            var teamList = new List<Team>();

            var teamNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < teamNum; i++)
            {
                var nextTeam = Console.ReadLine().Split('-').ToArray();

                var founder = nextTeam[0];
                var teamName = nextTeam[1];
                
                if (teamList.Exists(t => t.Name == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teamList.Exists(t => t.Creator == founder))
                {
                    Console.WriteLine($"{founder} cannot create another team!");
                }
                else
                {
                    var newTeam = CreateNewTeam(teamName, founder);
                    teamList.Add(newTeam);

                    Console.WriteLine($"Team {teamName} has been created by {founder}!");
                }       
            }

            var memberLine = Console.ReadLine();

            while (memberLine != "end of assignment")
            {
                var joinTeam = memberLine.Split('>').ToArray();

                var member = joinTeam[0].TrimEnd('-');
                var teamName = joinTeam[1];
                var currentTeam = teamList.FirstOrDefault(t => t.Name == teamName);

                var alreadyJoined = teamList.Exists(t => t.Creator == member);
                alreadyJoined = alreadyJoined || teamList.Exists(t => t.Members.Contains(member));

                if (currentTeam == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (alreadyJoined)
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                }
                else
                {
                    currentTeam.Members.Add(member);
                }

                memberLine = Console.ReadLine();
            }

            var disbandedTeams = teamList
                .Where(t => t.Members.Count == 0)
                .OrderBy(t => t.Name)
                .ToList();

            var formedTeams = teamList
                .Where(t => t.Members.Count > 0)
                .OrderByDescending(t => t.Members.Count)
                .ThenBy(t => t.Name)
                .ToList();
            
                foreach (var t in formedTeams)
                {
                    Console.WriteLine(t.Name);
                    Console.WriteLine($"- {t.Creator}");
                    foreach (var person in t.Members)
                    {
                        Console.WriteLine($"-- {person}");
                    }
                }
            
                Console.WriteLine("Teams to disband:");

                foreach (var t in disbandedTeams)
                {
                    Console.WriteLine(t.Name);
                }
        }

        public static Team CreateNewTeam(string teamName, string founder)
        {
            var theTeam = new Team
            {
                Name = teamName,
                Creator = founder,
                Members = new SortedSet<string>()
            };

            return theTeam;
        }
    }
}
