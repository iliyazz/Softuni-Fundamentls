using System;
using System.Collections.Generic;
using System.Linq;

namespace P04Students
{
    class Student
    {
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
                Student student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age,
                    HomeTown = homeTown
                };
                students.Add(student);
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
    }
}
