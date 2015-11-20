using System;

namespace FootballLeague
{
    class LeagueManager
    {
        private static void AddTeam(string name, string nickname, DateTime dateOfFounding)
        {
            Team team = new Team(name, nickname, dateOfFounding);
            if (League.CheckIfTeamExist(team))
            {
                throw new InvalidOperationException("This team already exist");
            }
            League.AddTeam(team);
            Console.WriteLine("Team - Confirmed");
        }

        private static void AddMatch(int id, string homeTeamName, string awayTeamName, string score)
        {
            Team t = new Team(homeTeamName, "     ", new DateTime(1850, 1, 1));
            t.Name = homeTeamName;
            Team s = new Team(awayTeamName, "        ", new DateTime(1850, 1, 1));
            s.Name = awayTeamName;
            Score sc;
            string[] scc = score.Split(' ');
            sc = new Score(int.Parse(scc[0]), int.Parse(scc[1]));
            Match match = new Match(t, s, sc, id);
            if (League.CheckIfMatchExist(match))
            {
                throw new InvalidOperationException("This match already exist");
            }
            League.AddMatch(match);
            Console.WriteLine("Match - Confirmed");
        }

        private static void AddPlayerToTeam(string firstName, string lastName, DateTime dateOfBirth, decimal salary, string team)
        {
            Team t = new Team(firstName, "       ", new DateTime(1850, 1, 1));
            t.Name = team;
            Player player = new Player(firstName, lastName, salary, dateOfBirth, t);
            if (t.CheckIfPlayerExist(player))
            {
                throw new InvalidOperationException("Player exist in this team");
            }
            t.AddPlayer(player);
            Console.WriteLine("Player - Confirmed");
        }

        public static void HandleInput(string input)
        {
            var inputArgs = input.Split();
            switch (inputArgs[0])
            {
                case "AddTeam":
                    AddTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]));
                    break;
                case "AddMatch":
                    AddMatch(int.Parse(inputArgs[1]), inputArgs[2], inputArgs[3], inputArgs[4] + " " + inputArgs[5]);
                    break;
                case "AddPlayerToTeam":
                    AddPlayerToTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]),
                        decimal.Parse(inputArgs[4]), inputArgs[5]);
                    break;
                case "ListTeams":
                    League.PrintTeams();
                    break;
                case "ListMatches":
                    League.PrintMatches();
                    break;
            }
        }
    }
}
