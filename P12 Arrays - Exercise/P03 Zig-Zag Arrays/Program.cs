using System;

namespace P03_Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numberOfRow = int.Parse(Console.ReadLine());
            string[] arr1 = new string[numberOfRow];
            string[] arr2 = new string[numberOfRow];
            for (int i = 0; i < numberOfRow; i++)
            {
                string[] arrCurrent = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);
                if (i % 2 == 0)
                {
                    arr1[i] = arrCurrent[0];
                    arr2[i] = arrCurrent[1];
                }
                else
                {
                    arr1[i] = arrCurrent[1];
                    arr2[i] = arrCurrent[0];
                }
            }
            Console.WriteLine(string.Join(" ", arr1));
            Console.WriteLine(string.Join(" ", arr2));
        }
    }
}
