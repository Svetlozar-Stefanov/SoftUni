using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamsToRegister = int.Parse(Console.ReadLine());
            if (teamsToRegister == 0)
            {
                return;
            }
            List<Team> listTeams = new List<Team>();

            for (int i = 0; i < teamsToRegister; i++)
            {
                string[] input = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);

                Team newTeam = new Team(input[0], input[1]);

                if (listTeams.Any(n => n.TeamName == newTeam.TeamName))
                {
                    Console.WriteLine($"Team {newTeam.TeamName} was already created!");
                }
                else if (listTeams.Any(c => c.Creator == newTeam.Creator))
                {
                    Console.WriteLine($"{newTeam.Creator} cannot create another team!");
                }
                else
                {
                    Console.WriteLine($"Team {newTeam.TeamName} has been created by {newTeam.Creator}!");

                    listTeams.Add(newTeam);
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split("->", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "end of assignment")
                {
                    break;
                }

                string peresonName = input[0];
                string teamToJoinName = input[1];

                if (!listTeams.Any(n=> n.TeamName == teamToJoinName))
                {
                    Console.WriteLine($"Team {teamToJoinName} does not exist!");
                }
                else if (listTeams.Any(n => n.TeamMembers.Contains(peresonName))
                || listTeams.Any(cr => cr.Creator == peresonName))
                {
                    Console.WriteLine($"Member {peresonName} cannot join team {teamToJoinName}!");
                }
                else
                {
                    for (int i = 0; i < listTeams.Count; i++)
                    {
                        if (listTeams[i].TeamName == teamToJoinName)
                        {
                            listTeams[i].TeamMembers.Add(peresonName);
                        }
                    }
                }
            }

            var disbandedTeams = listTeams.OrderBy(x => x.TeamName).Where(x => x.TeamMembers.Count == 0);
            var finalList = listTeams.OrderByDescending(x => x.TeamMembers.Count).ThenBy(x => x.TeamName).Where(x => x.TeamMembers.Count > 0);

            foreach (var team in finalList)
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.TeamMembers.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach (var team in disbandedTeams)
            {
                Console.WriteLine(team.TeamName);
            }
        }

        private static bool CreatorOfTeam(List<Team> listTeams, string peresonName)
        {
            foreach (var team in listTeams)
            {
                if (team.Creator == peresonName)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool TeamExists(List<Team> listTeams, string teamToJoinName)
        {
            foreach (var team in listTeams)
            {
                if (team.TeamName == teamToJoinName)
                {
                    return true;
                }
            }
            return false;
        }
    }

    class Team
    {
        public Team(string creator, string teamName)
        {
            Creator = creator;
            TeamName = teamName;
            TeamMembers = new List<string>();
        }
        public string Creator;
        public string TeamName;
        public List<string> TeamMembers { get; set; }
    }
}
