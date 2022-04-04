using System;

namespace P01_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            if (dataType == "int")
            {
                PrinInteger();
            }
            else if (dataType == "real")
            {
                PrinReal();
            }
            else if (dataType == "string")
            {
                PrinString();
            }
        }
        static void PrinInteger()
        {
            Console.WriteLine(int.Parse(Console.ReadLine()) * 2);

        }
        static void PrinReal()
        {
            Console.WriteLine($"{double.Parse(Console.ReadLine()) * 1.5:F2}");

        }
        static void PrinString()
        {
            Console.WriteLine($"${Console.ReadLine()}$");

        }

    }
}
