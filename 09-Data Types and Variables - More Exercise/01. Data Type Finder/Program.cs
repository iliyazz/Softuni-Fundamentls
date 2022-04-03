using System;

namespace P01._Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputData = string.Empty;
            do
            {
                inputData = Console.ReadLine();
                int integerType = 0;
                bool isInteger = int.TryParse(inputData, out integerType);
                double doubleType = 0.0;
                bool isDouble = double.TryParse(inputData, out doubleType);
                char charType = '\0';
                bool isChar = char.TryParse(inputData, out charType);
                bool boolType = false;
                bool isBool = bool.TryParse(inputData, out boolType);

                if (isInteger)
                {
                    Console.WriteLine($"{inputData} is integer type");
                }
                else if (isDouble)
                {
                    Console.WriteLine($"{inputData} is floating point type");
                }
                else if (isChar)
                {
                    Console.WriteLine($"{inputData} is character type");
                }
                else if (isBool)
                {
                    Console.WriteLine($"{inputData} is boolean type");
                }
                else if (inputData != "END")
                {
                    Console.WriteLine($"{inputData} is string type");
                }
            } while (inputData != "END");
        }
    }
}
