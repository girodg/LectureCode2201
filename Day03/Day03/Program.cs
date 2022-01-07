﻿using System;
using System.Collections.Generic;

namespace Day03
{
    class Program
    {
        static void Main(string[] args)
        {
            Arrays();

            Dictionary<string, float> menu = new Dictionary<string, float>()
            {
                //{key,value}
                {"Hamburger", 2.50F },//key-value pair
                {"Cheesy Hamburger", 2.75F }
            };

            //will throw an exception if the key already exists
            menu.Add("Fries", 0.99F);

            //will NOT throw an exception. will overwrite the value if key already exists.
            menu["Curly Fries"] = 1.50F;
            Console.WriteLine("------------MENU-------------");
            foreach (KeyValuePair<string,float> menuItem in menu)
            {
                Console.WriteLine($"{menuItem.Value,7:C2} {menuItem.Key}");
            }

            Random randy = new Random();
            Dictionary<string, double> pg2 = new Dictionary<string, double>()
            {
                {"Terrell",  randy.NextDouble() * 100},
                {"Timothy",  randy.NextDouble() * 100},
                {"Steven",  randy.NextDouble() * 100}
            };
            pg2.Add("William", randy.NextDouble() * 100);
            pg2.Add("Michael", randy.NextDouble() * 100);

            pg2["Will"] = randy.NextDouble() * 100;
            pg2["David"] = randy.NextDouble() * 100;
            pg2["Sebastian"] = randy.NextDouble() * 100;
            pg2["Glenn"] = randy.NextDouble() * 100;
            pg2["Andre"] = randy.NextDouble() * 100;
            pg2["Dominic"] = randy.NextDouble() * 100;
            pg2["Jaleen"] = randy.NextDouble() * 100;
            pg2["Amari"] = randy.NextDouble() * 100;
            pg2["Jaelen"] = randy.NextDouble() * 100;
            pg2["Benjamin"] = randy.NextDouble() * 100;
            pg2["Edward"] = randy.NextDouble() * 100;
            pg2["Victoria"] = randy.NextDouble() * 100;
            pg2["Khyren"] = randy.NextDouble() * 100;

            PrintGrades(pg2);
        }

        static void PrintGrades(Dictionary<string, double> grades)
        {
            Console.WriteLine("-----------GRADES-----------");
            foreach (var student in grades)
            {
                Console.Write($"{student.Key}");
                Console.CursorLeft = 15;
                Console.ForegroundColor = (student.Value < 59.5) ? ConsoleColor.Red :
                                          (student.Value < 69.5) ? ConsoleColor.DarkYellow :
                                          (student.Value < 79.5) ? ConsoleColor.Yellow :
                                          (student.Value < 89.5) ? ConsoleColor.Blue :
                                                               ConsoleColor.Green;

                Console.WriteLine($"{student.Value,7:N2}");
                Console.ResetColor();
            }
        }

        static void Arrays()
        {
            double[] grades = new double[10];
            Random randy = new Random();
            for (int i = 0; i < 10; i++)
            {
                grades[i] = randy.NextDouble() * 100;
            }
            PrintGrades(grades);
        }

        private static void PrintGrades(double[] grades)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                Console.ForegroundColor = (grades[i] < 59.5) ? ConsoleColor.Red :
                                          (grades[i] < 69.5) ? ConsoleColor.DarkYellow :
                                          (grades[i] < 79.5) ? ConsoleColor.Yellow :
                                          (grades[i] < 89.5) ? ConsoleColor.Blue :
                                                               ConsoleColor.Green;
                Console.WriteLine($"{grades[i],7:N2}");
            }
            Console.ResetColor();
        }
    }
}