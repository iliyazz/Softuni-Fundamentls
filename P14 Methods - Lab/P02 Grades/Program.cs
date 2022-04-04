using System;

namespace P02_Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GradeResult(double.Parse(Console.ReadLine()));
        }
        
        static void GradeResult ( double grade)
        {
            if (grade >= 5.5)
            {
                Console.WriteLine("Excellent");
            }
            else if (grade >= 4.5)
            {
                Console.WriteLine("Very good");
            }
            else if (grade >= 3.5)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 3.0)
            {
                Console.WriteLine("Poor");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
