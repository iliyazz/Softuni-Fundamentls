using System;
using System.Text;

namespace P07_Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringFromUser = Console.ReadLine();
            int repeatedNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatedString(stringFromUser, repeatedNumber));
        }

        static string RepeatedString(string stringFromUser, int repeatedNumber)
        {
            StringBuilder newString = new StringBuilder();
            for (int i = 0; i < repeatedNumber; i++)
            {
                newString.Append(stringFromUser);
            }
            return newString.ToString();
        }
    }
}
