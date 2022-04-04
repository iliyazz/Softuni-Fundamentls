using System;

namespace P02_Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1Coordinate = double.Parse(Console.ReadLine());
            double y1Coordinate = double.Parse(Console.ReadLine());
            double x2Coordinate = double.Parse(Console.ReadLine());
            double y2Coordinate = double.Parse(Console.ReadLine());
            if (DistanceFromCenter(x1Coordinate, y1Coordinate) > DistanceFromCenter(x2Coordinate, y2Coordinate))
            {
                Console.WriteLine($"({x2Coordinate}, {y2Coordinate})");
                
            }
            else
            {
                Console.WriteLine($"({x1Coordinate}, {y1Coordinate})");
            }

        }
        static double DistanceFromCenter(double xCoordinate, double yCoordinate)
        {
            return Math.Pow((Math.Pow(xCoordinate, 2) + Math.Pow(yCoordinate, 2)), 0.5);
        }
    }
}
