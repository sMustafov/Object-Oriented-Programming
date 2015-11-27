namespace BankOfKurtovoKonare
{
    public class Mortgage : Account
    {
        public Mortgage(Customer customer, double balance, int interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override double CalculateInterest(int months)
        {
            if (months <= 6 && this.Customer == Customer.Individual)
            {
                return 0;
            }
            else if (months <= 12 && this.Customer == Customer.Company)
            {
                this.InterestRate = Balance * (1 + InterestRate * months);
                return 0.5 * this.InterestRate;
            }
            return this.InterestRate = Balance * (1 + InterestRate * months);
        }
    }
}