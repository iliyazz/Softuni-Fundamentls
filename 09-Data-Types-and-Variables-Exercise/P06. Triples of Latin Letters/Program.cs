using System;

namespace P06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 'a'; i < 'a' + number; i++)
            {
                for (int j = 'a'; j < 'a' + number; j++)
                {
                    for (int k = 'a'; k < 'a' + number; k++)
                    {
                        Console.WriteLine($"{(char)i}{(char)j}{(char)k}");
                    }
                }
            }
        }
    }
}
