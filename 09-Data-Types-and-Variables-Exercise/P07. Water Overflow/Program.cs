using System;

namespace P07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int TankCapacity = 255;
            int number = int.Parse(Console.ReadLine());
            int quantityOfWater = 0;
            for (int i = 1; i <= number; i++)
            {
                int currentQuantity = int.Parse(Console.ReadLine());
                if (TankCapacity >= quantityOfWater + currentQuantity)
                {
                    quantityOfWater += currentQuantity;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(quantityOfWater);
        }
    }
}
