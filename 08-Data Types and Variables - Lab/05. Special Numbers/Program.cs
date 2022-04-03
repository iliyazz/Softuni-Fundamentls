using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= number; i++)
            {
                int currentNumber = i;
                int currenDigitSum = 0;
                while (currentNumber != 0)
                {
                    currenDigitSum += currentNumber % 10;
                    currentNumber /= 10; 
                }
                bool isSpecialNumber = currenDigitSum == 5 || currenDigitSum == 7 || currenDigitSum == 11;
                Console.WriteLine($"{i} -> {isSpecialNumber}");
            }
        }
    }
}
