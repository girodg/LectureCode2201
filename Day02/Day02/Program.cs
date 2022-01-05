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
