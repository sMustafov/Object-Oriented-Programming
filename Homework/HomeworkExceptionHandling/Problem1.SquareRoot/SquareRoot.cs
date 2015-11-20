using System;

namespace Problem1.SquareRoot
{
    class SquareRoot
    {
        public static double Sqrt(double num)
        {
            if (num < 0)
            {
               throw new ArgumentOutOfRangeException("Invalid number");
            }
                return Math.Sqrt(num);
        }
    
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine(Sqrt(n));
            }
            catch (ArgumentOutOfRangeException e)
            {
               Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("GoodBye");
            }
        }
    }
}
