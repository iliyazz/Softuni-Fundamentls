using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Sum_Adjacent_Equal_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> listOfNumbers = new List<double>();
            listOfNumbers =  Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
            for (int i = 0; i < listOfNumbers.Count -1; i++)
            {
                if (listOfNumbers[i] == listOfNumbers[i + 1])
                {
                    listOfNumbers[i] += listOfNumbers[i + 1];
                   listOfNumbers.RemoveAt(i+1);
                    i = -1;
                }
            }
            Console.WriteLine(String.Join(" ", listOfNumbers));
        }
    }
}
