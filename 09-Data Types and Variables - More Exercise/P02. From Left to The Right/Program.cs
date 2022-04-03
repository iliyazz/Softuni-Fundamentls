using System;
using System.Text;

namespace P02._From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numberOfLines; i++)
            {
                string currenInput = Console.ReadLine();
                StringBuilder firstNumberString = new StringBuilder();
                StringBuilder secondNumberString = new StringBuilder();
                int counter = 0;
                while (currenInput[counter] != ' ')
                {
                    firstNumberString.Append(currenInput[counter]);
                    counter++;
                }
                counter++;
                while (currenInput.Length > counter)
                {
                    secondNumberString.Append(currenInput[counter]);
                    counter++;
                }
                long firstNumber = long.Parse((string)firstNumberString.ToString());
                long secondNumber = long.Parse((string)secondNumberString.ToString());
                long biggestNumber = 0;
                int lenghtOfBiggesNumber = 0;
                if (firstNumber > secondNumber)
                {
                    biggestNumber = firstNumber;
                    lenghtOfBiggesNumber = firstNumberString.Length;
                }
                else
                {
                    biggestNumber = secondNumber;
                    lenghtOfBiggesNumber = secondNumberString.Length;
                }
                long sum = 0;
                for (int k = 1; k <= lenghtOfBiggesNumber; k++)
                {
                    sum += Math.Abs(biggestNumber) % 10;
                    biggestNumber /= 10;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
