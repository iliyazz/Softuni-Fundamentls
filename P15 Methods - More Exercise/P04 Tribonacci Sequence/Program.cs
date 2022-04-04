using System;

namespace P04_Tribonacci_Sequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint num = uint.Parse(Console.ReadLine());
            Tribonacci(num);
        }
        static void Tribonacci(uint num)
        {
            uint n1 = 0;
            uint n2 = 0;
            uint n3 = 1;
            uint current = 0;
            Console.Write(1);
            for (int i = 1; i < num; i++)
            {
                current = n1 + n2 + n3;
                n1 = n2;
                n2 = n3;
                n3 = current;
                Console.Write($" {current}");
            }

        }

    }
}
