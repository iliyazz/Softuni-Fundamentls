using System;

namespace P06_Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            Console.WriteLine(GetRectangleArea(width, hight));
        }

        static double GetRectangleArea(double width, double hight)
        {
           return width * hight;
        }
    }
}
