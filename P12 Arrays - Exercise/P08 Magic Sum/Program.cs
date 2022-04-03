using System;
using System.Linq;

namespace P08_Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int sumFromCons = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr1.Length - 1; i++)
            {
                for (int j = i+1; j < arr1.Length; j++)
                {
                    if (arr1[i] + arr1[j] == sumFromCons)
                    {
                        Console.WriteLine($"{arr1[i]} {arr1[j]}");
                    }
                }
            }
        }
    }
}
