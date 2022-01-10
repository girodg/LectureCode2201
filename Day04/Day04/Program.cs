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
    }
}
