using System;
using System.Linq;

namespace P01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] peoplesPerWagons = new int[numberOfWagons];
            for (int i = 0; i < peoplesPerWagons.Length; i++)
            {
                peoplesPerWagons[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(String.Join(" ", peoplesPerWagons));
            Console.WriteLine(peoplesPerWagons.Sum());
        }
    }
}
