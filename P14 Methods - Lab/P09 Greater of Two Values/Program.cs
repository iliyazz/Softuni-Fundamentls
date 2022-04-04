using System;

namespace P09_Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfString = Console.ReadLine();
            switch (typeOfString)
            {
                case "int":
                    int string1Int = int.Parse(Console.ReadLine());
                    int string2Int = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(string1Int, string2Int));
                    break;
                case "char":
                    char string1Char = char.Parse(Console.ReadLine());
                    char string2Char = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(string1Char, string2Char));
                    break;
                case "string":
                    string string1 = Console.ReadLine();
                    string string2 = Console.ReadLine();
                    Console.WriteLine(GetMax(string1, string2));
                    break;
                default:
                    break;
            }


        }
        static int GetMax(int string1, int string2)
        {
            if (string1 > string2)
            {
                return string1;
            }
            else
            {
                return string2;
            }
        }
        static char GetMax(char string1, char string2)
        {
            if (string1 > string2)
            {
                return string1;
            }
            else
            {
                return string2;
            }
        }
        static string GetMax(string string1, string string2)
        {
            int comparison = string.Compare(string1, string2);
            if (comparison > 0)
            {
                return string1;
            }
            else
            {
                return string2;
            }
        }
    }
}
