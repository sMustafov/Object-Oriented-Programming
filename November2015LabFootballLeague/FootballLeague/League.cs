using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballLeague
{
    class League
    {
        private static List<Team> teams = new List<Team>();
        private static List<Match> matches = new List<Match>();

        public static IEnumerable<Team> Teams
        {
            get { return teams; }
        }

        public static IEnumerable<Match> Matches
        {
            get { return matches; }
        }

        public static void AddTeam(Team team)
        {
            if (CheckIfTeamExist(team))
            {
                throw new InvalidOperationException("This team already exist");
            }
            teams.Add(team);
        }

        public static bool CheckIfTeamExist(Team team)
        {
            return Teams.Any(t => t.Name == team.Name);
        }

        public static void AddMatch(Match match)
        {
            if (CheckIfMatchExist(match))
            {
                throw new InvalidOperationException("This match already exist");
            }
            matches.Add(match);
        }

        public static bool CheckIfMatchExist(Match match)
        {
            return Matches.Any(m => m.ID == match.ID);
        }
        public static void PrintTeams()
        {
            List<Team> list = new List<Team>(teams);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].Name);
            }
        }

        public static void PrintMatches()
        {
            List<Match> list = new List<Match>(matches);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].HomeTeam.Name + " " + list[i].AwayTeam.Name + " "
                    + list[i].Score.HomeTeamGoals + ":" + list[i].Score.AwayTeamGoals);
            }

        }
    }
}
