using System;

namespace P04_Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintTriangle(int.Parse(Console.ReadLine()));
        }

        static void PrintTriangle(int number)
        {
            for (int i = 1; i <= number; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write($"{k} ");
                }
                Console.WriteLine();
            }
            for (int i = number - 1; i >= 1; i--)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write($"{k} ");
                }
                Console.WriteLine();
            }
        }
    }
}
