using System;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMessage();

            string userInput = "Please enter your name: ";
            string msg = GetMessage(userInput);

            PrintMessage(msg);

            int number = 5;
            Factor(ref number, 2);
        }

        private static int Factor(ref int steev, int factor)
        {
            steev *= factor;
            return 5;
        }

        private static string GetMessage(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        static void PrintMessage(string msg)
        {
            Console.WriteLine(msg);
        }
        static void PrintMessage()
        {
            Console.WriteLine("Hello Gotham.");
        }
    }
}
