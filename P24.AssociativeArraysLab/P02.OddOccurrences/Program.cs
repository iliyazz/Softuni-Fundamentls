using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] wordsArr = Console
                .ReadLine()
                .ToLower()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            Dictionary<string, int> wordsDict = new Dictionary<string, int>();
            foreach (string item in wordsArr)
            {
                if (wordsDict.ContainsKey(item))
                {
                    wordsDict[item]++;
                }
                else
                {
                    wordsDict.Add(item, 1);
                }
            }
            string[] words = wordsDict
                .Where(x => x.Value % 2 != 0)
                .Select(x => x.Key)
                .ToArray();
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
