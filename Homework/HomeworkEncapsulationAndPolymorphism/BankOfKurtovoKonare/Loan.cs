namespace BankOfKurtovoKonare
{
    public class Loan : Account
    {
        public Loan(Customer customer, double balance, int interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override double CalculateInterest(int months)
        {
            if ((months <= 3 && this.Customer == Customer.Individual) || (months <= 2 && this.Customer == Customer.Company))
            {
                return 0;
            }
            return this.InterestRate = Balance * (1 + InterestRate * months);
        }
    }
}