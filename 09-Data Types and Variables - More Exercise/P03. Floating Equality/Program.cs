using System;
using System.Numerics;

namespace P03._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal number1 = decimal.Parse(Console.ReadLine());
            decimal number2 = decimal.Parse(Console.ReadLine());
            const decimal EpsPrecision = 0.000001M;
            //decimal difference = Math.Abs(decimal.Subtract(number1, number2));


            if (Math.Abs(number1 - number2) < EpsPrecision)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
