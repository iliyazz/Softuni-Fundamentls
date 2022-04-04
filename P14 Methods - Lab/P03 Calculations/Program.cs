using System;

namespace P03_Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mathOperation = Console.ReadLine();
            int nnumber1 = int.Parse(Console.ReadLine());
            int nnumber2 = int.Parse(Console.ReadLine());

            switch (mathOperation)
            {
                case "add":
                    AddOperation(nnumber1, nnumber2);
                    break;
                case "multiply":
                    MultiplyOperation(nnumber1, nnumber2);
                    break;
                case "subtract":
                    SustractOperation(nnumber1, nnumber2);
                    break;
                case "divide":
                    DivideOperation(nnumber1, nnumber2);
                    break;
                default:
                    break;
            }

        }

        static void AddOperation(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }

        static void MultiplyOperation(int number1, int number2)
        {
            Console.WriteLine(number1 * number2);
        }

        static void SustractOperation(int number1, int number2)
        {
            Console.WriteLine(number1 - number2);
        }

        static void DivideOperation(int number1, int number2)
        {
            Console.WriteLine(number1 / number2);
        }
    }
}
