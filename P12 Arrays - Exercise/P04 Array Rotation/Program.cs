using System;

namespace P04_Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrOriginal = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            int numberOfRotations = int.Parse(Console.ReadLine());
            numberOfRotations %= arrOriginal.Length;
            string firstMember = string.Empty;
            for (int i = 0; i < numberOfRotations; i++)
            {
                firstMember = arrOriginal[0];
                for (int j = 0; j < arrOriginal.Length - 1; j++)
                {
                    arrOriginal[j] = arrOriginal[j + 1];
                }
                arrOriginal[arrOriginal.Length-1] = firstMember;
            }
            Console.WriteLine(string.Join(" ", arrOriginal));
        }
    }
}
