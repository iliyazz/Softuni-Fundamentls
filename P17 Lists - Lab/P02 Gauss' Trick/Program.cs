using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_Gauss__Trick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers1 = new List<int>();
            listOfNumbers1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < listOfNumbers1.Count / 2; i++)
            {
                int current = listOfNumbers1[i] + listOfNumbers1[listOfNumbers1.Count - 1 - i];
                result.Add(current);
            }
            if (listOfNumbers1.Count % 2 != 0)
            {
                result.Add(listOfNumbers1[listOfNumbers1.Count / 2]);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
