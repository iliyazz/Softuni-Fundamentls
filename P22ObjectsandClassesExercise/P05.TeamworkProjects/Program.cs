using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.TeamworkProjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            RegiserTeam(teams, teamsCount);
            RegisterMember(teams);

            List<Team> finalTeam = teams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName)
                .ToList();


            List<Team> disbandedTeam = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList();
            
            PrintValidTeams(finalTeam);
            PrintDisbandedTeam(disbandedTeam);

        }

        static void PrintDisbandedTeam(List<Team> disbandetTeam)
        {
            Console.WriteLine("Teams to disband:");
            foreach (Team item in disbandetTeam)
            {
                Console.WriteLine(item.TeamName);
            }
        }

        static void PrintValidTeams (List<Team> finalTeam)
        {
            foreach (Team item in finalTeam)
            {
                Console.WriteLine(item.TeamName);
                Console.WriteLine($"- {item.Creator}");

                foreach (string member in item.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
        }


        static void RegisterMember(List<Team> teams)
        {
            string command = String.Empty;
            while ((command=Console.ReadLine()) != "end of assignment")
            {
                string[] cmdArg = command.Split("->", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string user = cmdArg[0];
                string team = cmdArg[1];
                Team searchedTeam = teams.FirstOrDefault(x => x.TeamName == team);
                if (searchedTeam == null)
                {
                    Console.WriteLine($"Team {team} does not exist!");
                    continue;
                }
                if (teams.Any(x => x.Members.Contains(user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {team}!");
                    continue;
                }
                if (teams.Any(x => x.Creator.Contains(user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {team}!");
                    continue;
                }


                searchedTeam.AddMember(user);
            }
        }



        static void RegiserTeam(List<Team> teams, int teamsCount)
        {
            for (int i = 0; i < teamsCount; i++)
            {
                string[] cmdArg = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string creator = cmdArg[0];
                string teamName = cmdArg[1];
                if (teams.Any(x => x.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }
                if (teams.Any(x => x.Creator == creator) )
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }
                Team newTeam = new Team(cmdArg[0], cmdArg[1]);
                teams.Add(newTeam);
                Console.WriteLine($"Team {teamName} has been created by {creator}!");
            }
        }
    }

    class Team
    {
        public Team(string creator, string teamName)
        {
            this.TeamName = teamName;
            this.Creator = creator;
            this.Members = new List<string>();

        }

        public string TeamName { get; set; }

        public string Creator { get; set; }

        public List<string> Members { get; set; }

        public void AddMember(string memberName)
        {
            Members.Add(memberName);
        }
    }
}
