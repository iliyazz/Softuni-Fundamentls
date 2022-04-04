using System;

namespace P03_Longer_Line
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1Line1 = double.Parse(Console.ReadLine());
            double y1Line1 = double.Parse(Console.ReadLine());
            double x2Line1 = double.Parse(Console.ReadLine());
            double y2Line1 = double.Parse(Console.ReadLine());
            double x1Line2 = double.Parse(Console.ReadLine());
            double y1Line2 = double.Parse(Console.ReadLine());
            double x2Line2 = double.Parse(Console.ReadLine());
            double y2Line2 = double.Parse(Console.ReadLine());

            LenghtOfLine(x1Line1, y1Line1, x2Line1, y2Line1, x1Line2, y1Line2, x2Line2, y2Line2);
        }
        static void LenghtOfLine(double x1L1, double y1L1, double x2L1, double y2L1, double x1L2, double y1L2, double x2L2, double y2L2)
        {
            double line1Lenght = Math.Sqrt(Math.Pow((x1L1 - x2L1),2) + Math.Pow((y1L1 - y2L1), 2));
            double line2Lenght = Math.Sqrt(Math.Pow((x1L2 - x2L2), 2) + Math.Pow((y1L2 - y2L2), 2));
            if (line1Lenght >= line2Lenght)
            {
                DistanceFromCenter(x1L1, y1L1, x2L1, y2L1);
            }
            else
            {
                DistanceFromCenter(x1L2, y1L2, x2L2, y2L2);
            }
        }
        static void DistanceFromCenter(double x1Coor, double y1Coor, double x2Coor, double y2Coor)
        {
            double distancePoint1 = Math.Sqrt(x1Coor * x1Coor + y1Coor * y1Coor);
            double distancePoint2 = Math.Sqrt(x2Coor * x2Coor + y2Coor * y2Coor);
            if (distancePoint1 <= distancePoint2)
            {
                Console.WriteLine($"({x1Coor}, {y1Coor})({x2Coor}, {y2Coor})");
            }
            else
            {
                Console.WriteLine($"({x2Coor}, {y2Coor})({x1Coor}, {y1Coor})");
            }
        }

    }
}
