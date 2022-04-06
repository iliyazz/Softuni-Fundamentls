using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInteger = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            listOfInteger.RemoveAll(x => x < 0);
            listOfInteger.Reverse();
            if (listOfInteger.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.Write(string.Join(" ", listOfInteger));
            }

        }
    }
}
