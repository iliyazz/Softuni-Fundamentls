using System;

namespace P10_Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int evenDigitSum = GetSumOfEvenDigits(number);
            int oddDigitSum = GetSumOfOddDigits(number);
            return evenDigitSum * oddDigitSum;
        }
        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            int currentDigit = 0;
            while (number != 0)
            {
                currentDigit = (number % 10);
                number /= 10;
                if (currentDigit % 2 == 0)
                {
                    sum += currentDigit;
                }
            }
            return sum;
        }
        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            int currentDigit = 0;
            while (number != 0)
            {
                currentDigit = (number % 10);
                number /= 10;
                if (currentDigit % 2 != 0)
                {
                    sum += currentDigit;
                }
            }
            return sum;
        }
    }
}
