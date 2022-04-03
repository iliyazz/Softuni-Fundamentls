using System;

namespace P08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string biggestModelKeg = string.Empty;
            double biggestVolume = 0;
            double currenVolumOfKeg = 0;
            for (int i = 1; i <= number; i++)
            {
                string currentModelKeg = Console.ReadLine();
                double currentRadiusOfKeg = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                currenVolumOfKeg = Math.PI * Math.Pow(currentRadiusOfKeg, 2) * height;
                if (currenVolumOfKeg > biggestVolume)
                {
                    biggestVolume = currenVolumOfKeg;
                    biggestModelKeg = currentModelKeg;
                }
            }
            Console.WriteLine(biggestModelKeg);
        }
    }
}
