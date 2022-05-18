using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] stringArr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            string stringWithoutWhitespace = string.Join("", stringArr).ToString();
            Dictionary<char, int> occurrences = new Dictionary<char, int>();
            foreach (var item in stringWithoutWhitespace)
            {
                if (occurrences.ContainsKey(item))
                {
                    occurrences[item]++;
                }
                else
                {
                    occurrences.Add(item, 1);
                }
            }
            foreach (var item in occurrences)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
