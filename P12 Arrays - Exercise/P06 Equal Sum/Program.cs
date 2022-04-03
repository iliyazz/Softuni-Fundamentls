using System;
using System.Linq;

namespace P06_Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int sumLeft = 0;
            int sumRight = 0;
            bool isEqual = false;
            for (int i = 0; i < arr1.Length; i++)
            {
                sumLeft = 0;
                sumRight = 0;
                for (int j = 0; j < i; j++)
                {
                    sumLeft += arr1[j];
                }

                for (int k =arr1.Length-1; k > i; k--)
                {
                    sumRight += arr1[k];
                }
                if (sumRight == sumLeft)
                {
                    Console.WriteLine(i);
                    isEqual = true;
                }
            }
            if (!isEqual)
            {
                Console.WriteLine("no");
            }
        }
    }
}
