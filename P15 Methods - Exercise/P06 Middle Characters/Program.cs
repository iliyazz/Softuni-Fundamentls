using System;

namespace P06_Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            PrintMiddleCharacters(word);
        }

        static void PrintMiddleCharacters(string word)
        {
            int wordLenght = word.Length;
            if (wordLenght % 2 == 0)
            {
                Console.Write(word[wordLenght / 2 - 1]);
                Console.Write(word[wordLenght / 2]);
            }
            else
            {
                Console.WriteLine(word[wordLenght / 2]);
            }
        }
    }
}
