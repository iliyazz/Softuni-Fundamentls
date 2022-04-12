using System;
using System.Collections.Generic;
using System.Linq;

namespace P05Students2._0
{
    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();
            while (command != "end")
            {
                string[] studentProp = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string firstName = studentProp[0];
                string lastName = studentProp[1];
                int age = int.Parse(studentProp[2]);
                string homeTown = studentProp[3];

                bool doesStudentExist = DoesStudentExist(students, firstName, lastName);
                if (doesStudentExist)
                {
                    Student existingStudent = GetExistingStudents(students, firstName, lastName);
                    existingStudent.FirstName = firstName;
                    existingStudent.LastName = lastName;
                    existingStudent.Age = age;
                    existingStudent.HomeTown = homeTown;
                    
                }
                else
                {
                    Student student = new Student(firstName, lastName, age, homeTown);
                    students.Add(student);
                }
                command = Console.ReadLine();
            }
            string cityname = Console.ReadLine();
            List<Student> filteredStudents = new List<Student>();
            filteredStudents = students.FindAll(x => x.HomeTown == cityname);
            foreach (Student item in filteredStudents)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} is { item.Age } years old.");
            }
        }
        static bool DoesStudentExist(List<Student> students, string firstName, string lastName)
        {
            foreach (Student item in students)
            {
                if (item.FirstName == firstName && item.LastName == lastName)
                {
                    return true;
                }
            }
                return false;
        }
        static Student GetExistingStudents(List<Student> students, string firstName, string lastName)
        {
            foreach (Student item in students)
            {
                if (item.FirstName == firstName && item.LastName == lastName)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
