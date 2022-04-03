using System;
using System.Linq;

namespace P02.Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(" ");
            string[] arr2 = Console.ReadLine().Split(" ");
            string[] arr3 = new string[arr2.Length];
            int counter = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < arr1.Length; j++)
                {
                    if (arr2[i] == arr1[j])
                    {
                        arr3[counter] = arr2[i];
                        counter++;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", arr3, 0, counter));
        }
    }
}
