using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> listOfNumbers1 = new List<int>();
            List<int> listOfNumbers2 = new List<int>();
            listOfNumbers1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            listOfNumbers2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int maxLenght = Math.Max(listOfNumbers1.Count, listOfNumbers2.Count);
            for (int i = 0; i < maxLenght; i++)
            {
                if (i < listOfNumbers1.Count)
                {
                    result.Add(listOfNumbers1[i]);
                }
                if (i < listOfNumbers2.Count)
                {
                    result.Add(listOfNumbers2[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
