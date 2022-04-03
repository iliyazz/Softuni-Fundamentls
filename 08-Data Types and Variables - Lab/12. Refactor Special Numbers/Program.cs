using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int sumCurrenDigit = 0;
                int currentNumber = i;
                while (currentNumber != 0)
                {
                    sumCurrenDigit += currentNumber % 10;
                    currentNumber /= 10;
                }
                bool isSpecialNum = (sumCurrenDigit == 5) || (sumCurrenDigit == 7) || (sumCurrenDigit == 11);
                Console.WriteLine("{0} -> {1}", i, isSpecialNum);
            }
        }
    }
}
