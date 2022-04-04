using System;

namespace P08_Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNumber = double.Parse(Console.ReadLine());
            int powerNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(MathPowerCustom(baseNumber, powerNumber));
        }

        static double MathPowerCustom(double baseNumber, int powerNumber)
        {
            double mathPowerResult = 1;
            if (powerNumber == 0)
            {
                return 1;
            }
            else
            {
                for (int i = 0; i < powerNumber; i++)
                {
                    mathPowerResult *= baseNumber;
                }
                return mathPowerResult;
            }
        }
    }
}
