using System;
using System.Collections.Generic;
using System.Linq;

namespace Customer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payment> payments = new List<Payment>
            {
                new Payment("Shopska salata", 5.95m),
                new Payment("Rakiq", 7.80m),
                new Payment("Jim Beam", 70m),
                new Payment("Cappy", 2.49m)
            };
            Customer pesho = new Customer("Pesho", "Peshov", "Peshov", "6605058888", "Tintqna 15", "0888800000", payments, CustomerType.Regular);
            Customer gosho = new Customer("Gosho", "Goshov", "Goshov", "690505696969", "Tintqna 17", "0878899900", payments, CustomerType.Diamond);

            Customer peshoCopy = (Customer)pesho.Clone();
            Console.WriteLine(pesho);
            Console.WriteLine(peshoCopy);

            Console.WriteLine(pesho == gosho);
            Console.WriteLine(pesho == peshoCopy);
            Console.WriteLine(Customer.Equals(pesho, gosho));
            Console.WriteLine();

            Customer[] customers = new[] { pesho, peshoCopy, gosho };
            Array.Sort(customers);
            Console.WriteLine(string.Join("\n", customers.ToList()));
        }
    }
}
