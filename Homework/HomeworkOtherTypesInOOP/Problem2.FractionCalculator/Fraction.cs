using System;
using System.Numerics;

namespace Problem2.FractionCalculator
{
    public struct Fraction
    {
        private BigInteger denominator;
        private BigInteger numerator;

        public BigInteger Numerator { get; set; }

        public BigInteger Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("The Denominator cannot be 0");
                }
                this.denominator = value;
            }
        }

        public Fraction(BigInteger numerator, BigInteger denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public static Fraction operator +(Fraction num1, Fraction num2)
        {
            BigInteger denominator = num1.Denominator * num2.Denominator;
            BigInteger numerator = ((num1.Numerator * denominator / num1.Denominator) + (num2.Numerator * denominator / num2.Denominator));
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator -(Fraction num1, Fraction num2)
        {
            BigInteger denominator = num1.Denominator * num2.Denominator;
            BigInteger numerator = ((num1.Numerator * denominator / num1.Denominator) - (num2.Numerator * denominator / num2.Denominator));
            return new Fraction(numerator, denominator);
        }

        public override string ToString()
        {
            return String.Format("{0}", (decimal)this.Numerator / (decimal)this.Denominator);
        }
    }
}