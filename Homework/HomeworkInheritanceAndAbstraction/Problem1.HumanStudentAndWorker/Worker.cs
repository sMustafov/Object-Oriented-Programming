using System;

namespace Problem1.HumanStudentAndWorker
{
    class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker (string firstName, string lastName, decimal weekSalary, int workHoursPerDay) 
            : base (firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary 
        {
            get { return this.weekSalary; }
            set
            {
                if (value < 0M)
                {
                    throw new ArgumentOutOfRangeException("The salary cannot be negative");
                }
                this.weekSalary = value;
            }
        }
        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value < 0M)
                {
                    throw new ArgumentOutOfRangeException("The hours should be between 0 and 24");
                }
                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = WeekSalary/(WorkHoursPerDay*7);
            return moneyPerHour;
        }

        public override string ToString()
        {
            string info = String.Format("Worker:\nFirst Name: {0}\nLast Name: {1}\nMoney per Hour: {2:0.00}\n", FirstName,
                LastName, MoneyPerHour());
            return info;
        }
    }
}
