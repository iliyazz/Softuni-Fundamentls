using System;
using System.Collections.Generic;
using System.Linq;

namespace P01RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sentance = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            Random rnd = new Random();

            for (int i = 0; i < sentance.Count; i++)
            {
                string currentWord = sentance[i];
                int randomIndex = rnd.Next(0, sentance.Count);
                sentance[i] = sentance[randomIndex];
                sentance[randomIndex] = currentWord;
            }
            foreach (var item in sentance)
            {
                Console.WriteLine(item);
            }
        }
    }
}
