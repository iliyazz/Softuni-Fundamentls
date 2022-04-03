using System;

namespace _07._Concat_Names
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name1 = Console.ReadLine();
            string Name2 = Console.ReadLine();
            string delimiter = Console.ReadLine();
            Console.Write($"{Name1}{delimiter}{Name2}");

        }
    }
}
