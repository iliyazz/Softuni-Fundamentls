using System;
using System.Collections.Generic;
using System.Linq;

namespace P07.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            int number = int.Parse(Console.ReadLine());
            for (int i = 0; i < number; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());
                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<double>());
                    students[studentName].Add(studentGrade);
                }
                else
                {
                    students[studentName].Add(studentGrade);
                }
            }
            foreach (var item in students)
            {
                if (item.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value.Average():F2}");
                }
            }
        }
    }
}
