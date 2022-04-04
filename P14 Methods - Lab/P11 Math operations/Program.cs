using System;

namespace P11_Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            char mathOperator = char.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Calculate(number1,mathOperator,number2));
        }
        static double Calculate(int number1, char mathOperator, int number2)
        {
            double result = 0;
            switch (mathOperator)
            {
                case '+':
                    result = number1 + number2;
                    break;
                case '-':
                    result = number1 - number2;
                    break;
                case '*':
                    result = number1 * number2;
                    break;
                case '/':
                    result = number1 / number2;
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
