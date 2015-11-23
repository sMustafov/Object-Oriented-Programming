using System;
using System.Numerics;

namespace Problem6.BitArray
{
    class BitArray
    {
        private readonly int[] number;

        public BitArray(int numb)
        {
            if (numb < 1 || numb > 100000)
            {
                throw new ArgumentOutOfRangeException("The number should be from 1 to 100000");
            }
            this.number = new int[numb];
        }

        public int this[int index]
        {
            set
            {
                if (index < 0 || index >= this.number.Length)
                {
                    throw new ArgumentOutOfRangeException("Bit position should be from 0 to " +  (this.number.Length - 1));
                }

                if (value != 0 && value != 1)
                {
                    throw new ArgumentException("Bit value should be either 0 or 1");
                }

                this.SetBitAtPos(index, value);
            }
        }

        public override string ToString()
        {
            return this.BinaryToDecimal();
        }

        private void SetBitAtPos(int pos, int bit)
        {
            this.number[pos] = bit;
        }

        private string BinaryToDecimal()
        {
            var decimalNum = new BigInteger(0);
            for (var i = 0; i < this.number.Length; i++)
            {
                decimalNum += int.Parse(this.number[i].ToString()) * (BigInteger)Math.Pow(2, i);
            }

            return decimalNum.ToString();
        }
    }


    class TestBitArray
    {
        static void Main(string[] args)
        {
            var num = new BitArray(100);
            num[0] = 1;
            num[45] = 1;
            Console.WriteLine(num);
        }
    }
}
