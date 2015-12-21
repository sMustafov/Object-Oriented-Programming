using System;

namespace Problem3.AsynchronousTimer
{
    class AsyncTimerMain
    {
        static void Main(string[] args)
        {
            //AsyncTimer printLetter = new AsyncTimer(PrintLetterOnConsole, 10, 500);
            //printLetter.Execute();

            //AsyncTimer printNumber = new AsyncTimer(PrintNumberOnConsole, 10, 1000);
            //printNumber.Execute();

            AsyncTimer password = new AsyncTimer(GeneratePassword, 10, 1000);
            password.Execute();
        }

        private static void PrintLetterOnConsole(int i)
        {
            char letter = (char)('a' + i);
            Console.WriteLine(letter);
        }

        private static void PrintNumberOnConsole(int i)
        {
            Console.WriteLine(i + 1);
        }

        private static void GeneratePassword(int i)
        {
            Random random = new Random();
            char letter = (char)random.Next(('0'), ('Z'));
            if (letter == ':' || letter == ';' || letter == '<' || letter == '=' || letter == '>' || letter == '?' ||
                letter == '@')
            {
                i--;
            }
            else if (letter >= 'A' && letter <= 'Z')
            {
                Console.Write((char)(letter + '*' - 10));
            }
            else
            {
                Console.Write(letter);
            }
        }
    }
}
