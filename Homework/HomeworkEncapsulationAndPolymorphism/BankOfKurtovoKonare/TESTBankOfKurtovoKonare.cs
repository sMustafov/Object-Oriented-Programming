using System;

namespace BankOfKurtovoKonare
{
    class TESTBankOfKurtovoKonare
    {
        static void Main(string[] args)
        {
            try
            {
                Deposit depositCompany = new Deposit(Customer.Company, 15000, 5);
                depositCompany.Withdraw(300);
                depositCompany.DepositMoney(100);
                depositCompany.CalculateInterest(15);
                Console.WriteLine("Deposit company:\n{0}", depositCompany);

                Deposit depositIndividual = new Deposit(Customer.Individual, 20000, 15);
                depositIndividual.Withdraw(700);
                depositIndividual.DepositMoney(560);
                depositIndividual.CalculateInterest(4);
                Console.WriteLine("Deposit individual:\n{0}", depositIndividual);

                Loan loanIndividual = new Loan(Customer.Individual, 10045, 45);
                loanIndividual.DepositMoney(5699);
                loanIndividual.CalculateInterest(15);
                Console.WriteLine("Loan individual:\n{0}", loanIndividual);

                Loan loanCompany = new Loan(Customer.Company, 256666, 9);
                loanCompany.DepositMoney(3000);
                loanCompany.CalculateInterest(6);
                Console.WriteLine("Loan company:\n{0}", loanCompany);

                Mortgage mortageIndividual = new Mortgage(Customer.Individual, 500, 5);
                mortageIndividual.DepositMoney(200.89);
                mortageIndividual.CalculateInterest(5);
                Console.WriteLine("Mortage individual:\n{0}", mortageIndividual);

                Mortgage mortageCompany = new Mortgage(Customer.Company, 650.45, 11);
                mortageCompany.DepositMoney(2000);
                mortageCompany.CalculateInterest(14);
                Console.WriteLine("Mortage company:\n{0}", mortageCompany);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}

