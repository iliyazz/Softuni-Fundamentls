using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentArg = Console.ReadLine().Split(' ').ToArray();
                Student newStudent = new Student(studentArg[0], studentArg[1], double.Parse(studentArg[2]));
                students.Add(newStudent);
            }
            List<Student> orderedStudent = new List<Student>();
            orderedStudent = students.OrderByDescending(x => x.Grade).ToList();
            foreach (Student student in orderedStudent)
            {
                Console.WriteLine(student);
            }
        }
    }

    class Student
    {
        public Student(string firstname, string lastName, double grade)
        {
            this.FirstName = firstname;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName}: {this.Grade:F2}";
        }
    }
}
