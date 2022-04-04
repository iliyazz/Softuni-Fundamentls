using System;

namespace P05_Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int sumResult = SumOfNumbers(number1, number2); 
            Console.WriteLine(SubstractOfNumbers(sumResult, number3));
        }
        static int SumOfNumbers(int number1, int number2)
        {
            return number1 + number2;
        }
        static int SubstractOfNumbers(int sumResult, int number3)
        {
            return sumResult - number3;
        }

    }
}
