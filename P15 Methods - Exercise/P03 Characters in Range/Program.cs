using System;

namespace P03_Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            PrintCharacter(firstChar, secondChar);
        }

        static void PrintCharacter(char firstChar, char secondChar)
        {
            char currentChar = '\0';
            if (firstChar > secondChar)
            {
                currentChar = firstChar;
                firstChar = secondChar;
                secondChar = currentChar;

            }
            for (int i = firstChar +1; i < secondChar; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
