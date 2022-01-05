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
        }

        static void ArrayChallenge()
        {
            int[] numbers = new int[10];
            Random rando = new Random();
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rando.Next();
            foreach (int number in numbers)
                Console.WriteLine(number);

            List<int> numList = new List<int>() { 5, 13 };
            numList.Add(42);
            numList.Add(20);
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
