using System;
using System.Collections.Generic;
using System.Linq;

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
            Console.WriteLine(numList[3]);
            numList.Remove(2);//use the index
            Console.WriteLine(numList[3]);

            ListChallenge();

            Split();
        }

        private static void Split()
        {

            string csv = "Steev,Steven,Stephen,-Stephie-Stefan";
            Console.WriteLine(csv);
            char[] delimiters = new char[] { ',', '-' };
            string[] data = csv.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
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
            int numberDropped = DropFailing(grades);
            Console.WriteLine($"{numberDropped} grades dropped.");
            PrintGrades(grades);
            List<double> newGrades = CurveGrades(grades);
            PrintGrades(newGrades);
        }

        private static List<double> CurveGrades(List<double> grades)
        {
            List<double> curved = grades.ToList();//clone the list
            for (int i = 0; i < curved.Count; i++)
            {
            //    curved[i] += 5;
            //    if (curved[i] > 100) curved[i] = 100;
                //OR
                curved[i] = (curved[i] > 95) ? 100 : curved[i] + 5;
            }
            return curved;
        }

        private static int DropFailing(List<double> grades)
        {
            int numDropped = 0;
            //Loop over the grades list and remove all failing grades. Keep track of how many grades were removed.
            //Return the # of grades that were removed
            //Call DropFailing from the ListChallenge method.
            //Print the number of failing grades that were removed.
            //Print the grades again.
            //for (int i = 0; i < grades.Count; i++)
            //{
            //    if(grades[i] < 59.5)
            //    {
            //        ++numDropped;
            //        grades.RemoveAt(i);
            //        --i;
            //    }
            //}
            //OR
            for (int i = grades.Count - 1; i >= 0; i--)
            {
                if (grades[i] < 59.5)
                {
                    ++numDropped;
                    grades.RemoveAt(i);
                }
            }

            return numDropped;
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


            //convert to a list
            //1> call ToList
            List<int> numList = numbers.ToList();

            //2> pass to the list constructor
            List<int> numList2 = new List<int>(numbers);

            //3> use a loop
            List<int> numList3 = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                numList3.Add(numbers[i]);
            }
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
