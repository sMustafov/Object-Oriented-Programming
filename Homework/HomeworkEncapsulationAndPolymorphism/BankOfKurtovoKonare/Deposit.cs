namespace BankOfKurtovoKonare
{
    public class Deposit : Account
    {
        public Deposit(Customer customer, double balance, int interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override double CalculateInterest(int months)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }
            return this.InterestRate = Balance * (1 + InterestRate * months);
        }

        public void Withdraw(double money)
        {
            this.Balance -= money;
        }
    }
}