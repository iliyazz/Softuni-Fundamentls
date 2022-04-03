using System;
using System.Linq;

namespace P05_Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] topInegegArr = new int[arr1.Length];
            int counter = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                bool isTopInteger = true;
                for (int j = i+1; j < arr1.Length; j++)
                {
                    if (arr1[i] <= arr1[j])
                    {
                        isTopInteger = false;
                        break;
                    }
                }
                if (isTopInteger)
                {
                    topInegegArr[counter++] = arr1[i];
                }
            }
            for (int i = 0; i < counter; i++)
            {
                Console.Write($"{topInegegArr[i]} ");
            }
        }
    }
}
