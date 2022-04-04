using System;

namespace P08_Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            decimal factorialNumber1 = CalcFactorial(number1);
            decimal factorialNumber2 = CalcFactorial(number2);
            Console.WriteLine($"{factorialNumber1 / factorialNumber2 :F2}");
        }
        static decimal CalcFactorial(decimal number)
        {
            decimal factorial = 1;
            for (int i = 1; i <= (int)number; i++)
            {
                factorial *= (decimal)i;
            }
            return factorial;
        }
    }
}
