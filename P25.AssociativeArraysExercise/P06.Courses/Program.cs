using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string , List<string>> courses = new Dictionary<string , List<string>>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command
                    .Split(':', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string courseName = tokens[0].Trim();
                string studentName = tokens[1].Trim();
                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses[courseName].Add(studentName);
                }
            }
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
