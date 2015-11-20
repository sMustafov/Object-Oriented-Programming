using System;

namespace FootballLeague
{
    class Score
    {
        private int homeTeamGoals;
        private int awayTeamGoals;

        public Score(int homeTeamGoals, int awayTeamGoals)
        {
            this.AwayTeamGoals = awayTeamGoals;
            this.HomeTeamGoals = homeTeamGoals;
        }

        public int HomeTeamGoals
        {
            get { return homeTeamGoals; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Goals cannot be negative");
                }
                this.homeTeamGoals = value;
            }
        }
        public int AwayTeamGoals
        {
            get { return awayTeamGoals; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Goals cannot be negative");
                }
                this.awayTeamGoals = value;
            }
        }
    }
}
