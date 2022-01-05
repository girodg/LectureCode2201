using System;
using System.Collections.Generic;

namespace Day02
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Add(10, 5);
            int sum = Add(2, 5);

            ArrayChallenge();


            List<int> numList = new List<int>() { 5, 13 };
            numList.Add(42);
            numList.Add(20);
            for (int i = 0; i < numList.Count; i++)
            {
                Console.WriteLine(numList[i]);
            }

            ListChallenge();
        }

        static void ListChallenge()
        {
            Random rando = new Random();
            List<double> grades = new List<double>(10);
            PrintInfo(grades);
            for (int i = 0; i < 10; i++)
            {
                grades.Add(rando.NextDouble() * 100);
                PrintInfo(grades);
            }
            PrintGrades(grades);
        }

        static void PrintGrades(List<double> pg2)
        {
            Console.WriteLine("------------GRADES-----------");
            //for (int i = 0; i < pg2.Count; i++)
            //{
            //    Console.WriteLine($"{pg2[i],7:N2}");
            //}
            foreach (var grade in pg2)
            {
                //if (grade < 59.5) Console.ForegroundColor = ConsoleColor.Red;
                //else if (grade < 69.5) Console.ForegroundColor = ConsoleColor.DarkYellow;
                //else if (grade < 79.5) Console.ForegroundColor = ConsoleColor.Yellow;
                //else if (grade < 89.5) Console.ForegroundColor = ConsoleColor.Blue;
                //else
                //    Console.ForegroundColor = ConsoleColor.Green;

                //ternary operator
                //(condition) ? :
                Console.ForegroundColor = (grade < 59.5) ? ConsoleColor.Red :
                                          (grade < 69.5) ? ConsoleColor.DarkYellow :
                                          (grade < 79.5) ? ConsoleColor.Yellow :
                                          (grade < 89.5) ? ConsoleColor.Blue :
                                          ConsoleColor.Green;

                Console.WriteLine($"{grade,5:N2}");
            }
            Console.ResetColor();
        }

        private static void PrintInfo(List<double> grades)
        {
            Console.WriteLine($"Count: {grades.Count}\tCapacity: {grades.Capacity}");
        }

        static void ArrayChallenge()
        {
            int[] numbers = new int[10];
            Random rando = new Random();
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rando.Next();
            foreach (int number in numbers)
                Console.WriteLine(number);

        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
