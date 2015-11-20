using System;

namespace FootballLeague
{
    class Player
    {
        private const int MinimumAllowedYear = 1980;

        private string firstName;
        private string lastName;
        private decimal salary;
        private DateTime dateOfBirth;
        private Team team;

        public Player(string firstName, string lastName, decimal salary, DateTime dateOfBirth, Team team)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.DateOfBirth = dateOfBirth;
            this.Team = team;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("First name cannot be smaller than 3 characters");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Last name cannot be smaller than 3 characters");
                }
                this.lastName = value;
            }
        }
        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary cannot be negative");
                }
                this.salary = value;
            }
        }
        public DateTime DateOfBirth
        {
            get { return this.dateOfBirth; }
            set
            {
                if (value.Year < 1980)
                {
                    throw new ArgumentException("Year of birth cannot be earlier than " + MinimumAllowedYear);
                }
                this.dateOfBirth = value;
            }
        }

        public Team Team
        {
            get { return team; }
            set { this.team = value; }
        }
    }
}
