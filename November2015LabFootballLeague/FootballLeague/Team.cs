using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballLeague
{
    class Team
    {
        private int MinimumAllowedYear = 1850;

        private string name;
        private string nickname;
        private DateTime dateFounded;
        private List<Player> players;

        public Team(string name, string nickname, DateTime dateFounded)
        {
            this.Name = name;
            this.Nickname = nickname;
            this.DateFounded = dateFounded;
            this.players = new List<Player>();
        }

        public IEnumerable<Player> Players
        {
            get { return players; }
        }

        public void AddPlayer(Player player)
        {
            if (CheckIfPlayerExist(player))
            {
                throw new InvalidOperationException("Player already exist for this team");
            }
            this.players.Add(player);
        }

        public bool CheckIfPlayerExist(Player player)
        {
            return this.players.Any(p => p.FirstName == player.FirstName && p.LastName == player.LastName);
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Name cannot be smaller than 5 characters");
                }
                this.name = value;
            }
        }
        public string Nickname
        {
            get { return this.nickname; }
            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Nickname cannot be smaller than 5 characters");
                }
                this.nickname = value;
            }
        }
        public DateTime DateFounded
        {
            get { return this.dateFounded; }
            set
            {
                if (value.Year < 1850)
                {
                    throw new ArgumentException("Year cannot be earlier than " + MinimumAllowedYear);
                }
                this.dateFounded = value;
            }
        }
    }
}
