using System;
using System.Text;

namespace P09_Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = string.Empty;
            
            while ((word = Console.ReadLine()) != "END")
            {
                Console.WriteLine(CheckPalindrom(word));
            }
        }
        static bool CheckPalindrom(string word)
        {
            StringBuilder palindrom = new StringBuilder();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                palindrom.Append(word[i]);
            }
            if (word == palindrom.ToString())
            {
                return true;
            }
            return false;
        }
    }
}
