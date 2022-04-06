using System;
using System.Collections.Generic;

namespace P04_List_of_Products
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < number; i++)
            {
                products.Add(Console.ReadLine());
            }
            products.Sort();
            int counter = 0;
            foreach (var item in products)
            {
                counter++;
                Console.WriteLine($"{counter}.{item}");
            }
        }
    }
}
