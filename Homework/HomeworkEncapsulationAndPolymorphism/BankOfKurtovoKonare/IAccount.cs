namespace BankOfKurtovoKonare
{
    public interface IAccount
    {
        Customer Customer { get; set; }

        double Balance { get; set; }

        double InterestRate { get; set; }

        void DepositMoney(double money);

        double CalculateInterest(int months);
    }
}