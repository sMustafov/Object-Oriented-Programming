using System;

namespace FootballLeague
{
    class Match
    {
        private Team homeTeam;
        private Team awayTeam;
        private Score score;
        private int id;

        public Match(Team homeTeam, Team awayTeam, Score score, int id)
        {
            this.homeTeam = homeTeam;
            this.awayTeam = awayTeam;
            this.score = score;
            this.id = id;
        }

        public Team GetWinner()
        {
            if (this.isDraw())
            {
                return null;
            }
            return this.score.HomeTeamGoals > this.score.AwayTeamGoals
                ? this.HomeTeam
                : this.AwayTeam;
        }

        private bool isDraw()
        {
            return this.Score.HomeTeamGoals == this.Score.AwayTeamGoals;
        }

        public Team HomeTeam
        {
            get { return this.homeTeam; }
        }

        public Team AwayTeam
        {
            get { return this.awayTeam; }
        }

        public Score Score
        {
            get { return this.score; }
        }

        public int ID
        {
            get { return this.id; }
        }
    }
}
