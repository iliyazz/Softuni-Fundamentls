using System;

namespace P04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                int charCode = (int)letter;
                sum += charCode;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
