using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_Append_Arrays_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> firstData = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            firstData.Reverse();
            List<int> finalData = new List<int>();
            foreach (var item in firstData)
            {
                finalData.AddRange(item.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToList());
            }
            Console.WriteLine(String.Join(" ", finalData));
        }
    }
}
