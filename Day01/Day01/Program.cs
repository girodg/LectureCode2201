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
            Factor(ref number);//factor will default to 2
            Factor(ref number, 5);

            TimeStamp(ref msg);
            PrintMessage(msg);

            SteevsInfo(out int age, out bool isCool);
            MyFavoriteNumber(out int myNumber);
            Console.WriteLine($"Your favorite number is {myNumber}?? WEird.");
        }

        private static void MyFavoriteNumber(out int number)
        {
            Console.Write("What is your favorite number? ");
           
            if (int.TryParse(Console.ReadLine(), out number) != true)
            {
                Console.WriteLine("Not a number, Steve!");
            }
        }

        static void SteevsInfo(out int age, out bool isCool)
        {
            age = 12;
            isCool = true;
        }

        static void TimeStamp(ref string message)
        {
            //prefix the time to the message
            //$ - interpolated string
            message = $"{DateTime.Now}:{message}";
        }

        private static int Factor(ref int steev, int factor = 2)
        {
            steev *= factor;
            return 5;
        }

        private static string GetMessage(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        static void PrintMessage(string msg = "Hello Gotham.")
        {
            Console.WriteLine(msg);
        }
    }
}
