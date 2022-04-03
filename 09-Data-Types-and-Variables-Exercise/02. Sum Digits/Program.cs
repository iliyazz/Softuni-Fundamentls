using System;

namespace P02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int sumOfDigit = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sumOfDigit += (int)number[i] - 48;
            }
            Console.WriteLine(sumOfDigit);
        }
    }
}
