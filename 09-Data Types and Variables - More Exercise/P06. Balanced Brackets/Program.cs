using System;
using System.Text;

namespace P06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            StringBuilder parenthesesStringBuilder = new StringBuilder();
            for (int i = 1; i <= numberOfLines; i++)
            {
                string current = Console.ReadLine();
                if (current == "(" || current == ")")
                {
                    parenthesesStringBuilder.Append(current);
                }
            }
            string parenthesesString = parenthesesStringBuilder.ToString();
            if (parenthesesString[0].Equals(")"))
            {
                Console.WriteLine("UNBALANCED");
                return;
            }
            if (parenthesesString.Length % 2 != 0)
            {
                Console.WriteLine("UNBALANCED");
                return;
            }
            for (int i = 0; i < parenthesesString.Length; i += 2)
            {
                if (!parenthesesString[i].Equals('(') || !parenthesesString[i+1].Equals(')'))
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
            }
            Console.WriteLine("BALANCED");
        }
    }
}
