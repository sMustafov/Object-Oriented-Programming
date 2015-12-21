using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace Problem2.InterestCalculator
{
    public delegate decimal CalculateInterest(decimal money, decimal interest, int year);

    class InterestCalculator
    {
        private decimal money;
        private decimal interest;
        private int year;
        private CalculateInterest intrestCalculation;

        public InterestCalculator(decimal money, decimal interest, int year, CalculateInterest interestCalculation)
        {
            this.Money = money;
            this.Interest = interest;
            this.Year = year;
            this.intrestCalculation = interestCalculation;
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Money cannot be negative");
                }
                this.money = value;
            }
        }

        public decimal Interest
        {
            get
            {
                return this.interest;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Interest cannot be negative");
                }
                this.interest = value;
            }
        }

        public int Year
        {
            get
            {
                return this.year;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Year cannot be negative");
                }
                this.year = value;
            }
        }

        public decimal Balance
        {
            get { return this.intrestCalculation(this.Money, this.Interest, this.Year); }
        }
    }
}
