using System;

namespace P02_Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            VowelsCount(word);
        }
        static void VowelsCount(string word)
        {
            string englishVowels = "aeiou";
            int countVowels = 0;
            foreach (char item in word)
            {
                if (englishVowels.Contains(item))
                {
                    countVowels++;
                }
            }
            Console.WriteLine(countVowels);
        }

    }
}
