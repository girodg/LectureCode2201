using System;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMessage();

            string msg = GetMessage();
        }

        private static string GetMessage()
        {
            Console.Write("Please enter a message: ");
            return Console.ReadLine();
        }

        static void PrintMessage()
        {
            Console.WriteLine("Hello Gotham.");
        }
    }
}
