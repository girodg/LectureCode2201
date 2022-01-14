using System;
using System.Collections.Generic;

namespace Day06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myNums = new List<int>() { 1, 6, 10, 14, 42 };
            int searchItem = 10;
            int foundIndex = LinearSearch(myNums, searchItem);
            Console.WriteLine($"Found {searchItem} at index {foundIndex}");

            searchItem = 13;
            foundIndex = LinearSearch(myNums, searchItem);
            if (foundIndex >= 0)
                Console.WriteLine($"Found {searchItem} at index {foundIndex}");
            else
                Console.WriteLine($"{searchItem} was not found.");
        }


        static int LinearSearch(List<int> numbers, int searchItem)
        {
            int index = -1;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == searchItem)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
