﻿using System;

namespace P01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());
            int number4 = int.Parse(Console.ReadLine());
            long result = (((long)number1 + (long)number2) / number3) * number4;
            Console.WriteLine(result);
            
        }
    }
}
