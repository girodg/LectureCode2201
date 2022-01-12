using System;

namespace Day05
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 0;
            Recursive(k);
            Console.Clear();

            int m = 0;
            Bats(m);

            for (int j = 0; j < 10; j++)
            {

            }
            for(; ;)
            {
                if(true)
                    break;
            }
            int i = 0;
            while (i < 10)
            {
                i++;
            }

            long result = Factorial(5);
            Console.WriteLine($"5! = {result}");
        }
        static void Recursive(int num)
        {
            Console.WriteLine(num);
            if (num < 10) //exit condition
            {
                int number = 5;
                Recursive(num + 1);
                Console.WriteLine(num);
            }
        }//returns from the method

        static void Bats(int m)
        {
            if(m < 100)
            {
                Console.Write((char)78);
                Console.Write((char)65);
                Console.Write(' ');
                Bats(m + 1);
            }
        }

        static long Factorial(int N)
        {
            long result = 1;
            if (N > 1)
            {
                result = N * Factorial(N - 1);
            }
            return result;
        }
        static long Factorial2(int N)
        {
            if (N <= 1) return 1;

            long result = N * Factorial2(N - 1);
            return result;
        }
    }
}
