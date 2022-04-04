using System;

namespace P10_Top_Numberr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int numForCheck = 1; numForCheck <= number; numForCheck++)
            {
                if (DivisibleByEight(numForCheck) && CheckForOddDigits(numForCheck))
                {
                    Console.WriteLine(numForCheck);
                }
            }
        }
        static bool DivisibleByEight(int numForCheck)
        {
            int sum = 0;
            bool resultDivisibleByEight = false;
            while (numForCheck != 0)
            {
                sum += numForCheck % 10;
                numForCheck /= 10;
            }
            if (sum %8 == 0)
            {
                resultDivisibleByEight = true;
            }
            return resultDivisibleByEight;
        }
        static bool CheckForOddDigits(int numForCheck)
        {
            bool IsOddDigits = false;
            int currentDigit = 0;
            while (numForCheck != 0)
            {
                currentDigit = numForCheck % 10;
                if (numForCheck % 2 == 1)
                {
                    IsOddDigits = true;
                }
                    numForCheck /= 10;
            }
            return IsOddDigits;
        }
    }
}
