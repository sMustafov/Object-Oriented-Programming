using System;

namespace Problem2.InterestCalculator
{
    class InterestCalculatorMain
    {
        public const int n = 12;
        public static decimal GetSimpleInterest(decimal money, decimal interest, int year)
        {
            decimal result = money * (1 + (interest * year));
            return Decimal.Round(result, 4);
        }

        public static decimal GetCompoundInterest(decimal money, decimal interest, int year)
        {
            decimal production = 1;
            decimal interestFactor = 1 + (interest / n);
            int pow = year * n;
            for (int i = 0; i < pow; i++)
            {
                production *= interestFactor;
            }
            decimal result = money * production;
            return Decimal.Round(result, 4);
        }

        static void Main()
        {
            InterestCalculator simpleInterestCalculator = new InterestCalculator(2500m, 0.072m, 15, GetSimpleInterest);
            Console.WriteLine(simpleInterestCalculator.Balance);

            InterestCalculator compoundInterestCalculator = new InterestCalculator(500m, 0.056m, 10, GetCompoundInterest);
            Console.WriteLine(compoundInterestCalculator.Balance);
        }
    }
}
