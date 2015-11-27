using System;
using System.Xml.Schema;

namespace BankOfKurtovoKonare
{
    public abstract class Account : IAccount
    {
        private Customer customer;
        private double balance;
        private double interestRate;

        protected Account(Customer customer, double balance, int interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer { get; set; }

        public double Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 0 && value > 12)
                {
                    throw new ArgumentOutOfRangeException("The balence cannot be negative");
                }
                this.balance = value;
            }
        }

        public double InterestRate
        {
            get { return this.interestRate; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The Interest rate cannot be negative");
                }
                this.interestRate = value;
            }
        }

        public abstract double CalculateInterest(int months);

        public void DepositMoney(double money)
        {
            this.Balance += money;
        }

        public override string ToString()
        {
            return string.Format("Account: {0}\nBalance = {1:0.00}\nInterest rate = {2}\n", this.GetType().Name, this.Balance, this.InterestRate);
        }
    }
}