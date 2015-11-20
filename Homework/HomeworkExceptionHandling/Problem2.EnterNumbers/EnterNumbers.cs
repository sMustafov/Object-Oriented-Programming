using System;
namespace Problem2.EnterNumbers
{
    class EnterNumbers
    {
        static void ReadNumbers(int first, int last)
        {
            int number = int.Parse(Console.ReadLine());
            if (number < first || number > last)
            {
                string message = String.Format("The number must be between {0} and {1}", first, last);
                throw new ArgumentOutOfRangeException(message);
            }
            
        }
        static void Main()
        {
            int first = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < 10)
                try
                {
                    ReadNumbers(first,last);
                    i++;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The number must be between {0} and {1}", first, last);
                }
            }
        }
    }
