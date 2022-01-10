using System;
using System.Collections.Generic;
using System.IO;

namespace Day04
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\temp\2201\sample.txt";
            char delimiter = '+';
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.Write("Batman rules!");
                sw.Write(delimiter);
                sw.Write(5);
                sw.Write(delimiter);
                sw.Write(13.7);
                sw.Write(delimiter);
                sw.Write(true);
            }
            filePath = "challenge.txt";
            WriteData(filePath);
            ReadData(filePath);

            filePath = @"C:\temp\2201\sample.txt";
            //1. open the file
            using (StreamReader sr = new StreamReader(filePath))
            {
                Console.WriteLine("-------DATA---------");
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split('+');
                    foreach (var item in data)
                    {
                        Console.WriteLine(item);
                    }
                }
            }//3. Close the file

            //does all 3 steps: opens, reads, closes the file
            string fileData = File.ReadAllText(filePath);
        }
        static void WriteData(string fPath)
        {
            List<int> nums = new List<int>() { 5, 4, 3, 2, 1 };

            char delimiter = '=';
            using (StreamWriter sw = new StreamWriter(fPath))
            {
                bool isFirst = true;
                for (int i = 0; i < nums.Count; i++)
                {
                    if(!isFirst)
                        sw.Write(delimiter);
                    sw.Write(nums[i]);
                    isFirst = false;
                }
            }
        }
        static void ReadData(string fPath)
        {
            //-------read the file and split the data
            string fileData = File.ReadAllText(fPath);
            string[] fData = fileData.Split('=');

            List<int> numbers = new List<int>();
            foreach (string item in fData)
            {
                if (int.TryParse(item, out int number))
                    numbers.Add(number);
            }
            Console.WriteLine("----------NUMBERS-----------");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
