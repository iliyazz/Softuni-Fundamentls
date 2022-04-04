using System;

namespace P05_Multiplication_Sign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] num = new double[3];
            num[0] = double.Parse(Console.ReadLine());
            num[1] = double.Parse(Console.ReadLine());
            num[2] = double.Parse(Console.ReadLine());
            if (IsZero(num))
            {
                Console.WriteLine("zero");
            }
            else if(CheckPositiv(num))
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
        static bool IsZero(double[] num)
        {
            if (num[0] == 0 || num[1] == 0 || num[2] == 0)
            {
                return true;
            }
                return false;

        }
        static bool CheckPositiv(double[] num)
        {
            int counter = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] < 0)
                {
                    counter++;
                }
            }
            if (counter % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
