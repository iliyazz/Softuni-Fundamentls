using System;
using System.Collections.Generic;
using System.Linq;

namespace P01CompanyRoster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfEmployee = int.Parse(Console.ReadLine());
            List<Employee> employees = new List<Employee>();
            for (int i = 0; i < numberOfEmployee; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = tokens[0];
                decimal salary = decimal.Parse(tokens[1]);
                string department = tokens[2];

                Employee current = new Employee(name, salary, department);
                employees.Add(current);
            }
            List<string> departmentList = new List<string>();
            string departmentWithMaxAveragesalary = FindHihgiestSalaryDepartments(employees, departmentList);
            List<Employee> orderedDepartment = employees
                .Where(x => x.Department == departmentWithMaxAveragesalary)
                .OrderByDescending(y => y.Salary)
                .ToList();
            foreach (Employee item in orderedDepartment)
            {
                Console.WriteLine($"{item.Name} {item.Salary:F2}");
            }

        }
        static string FindHihgiestSalaryDepartments(List<Employee> employees, List<string> departmentList)
        {
            foreach (Employee item in employees)
            {
                if (!departmentList.Contains(item.Department))
                {
                    departmentList.Add(item.Department);
                }
            }
            decimal maxAverageSalary = 0;
            decimal currentAverageSalary = 0;
            string departmentWithMaxAveragesalary = string.Empty;
            foreach (string item in departmentList)
            {
                currentAverageSalary = employees
                    .Where(x => x.Department == item)
                    .Average(y => y.Salary);
                if (currentAverageSalary > maxAverageSalary)
                {
                    maxAverageSalary = currentAverageSalary;
                    departmentWithMaxAveragesalary = item;
                }
            }
            Console.WriteLine($"Highest Average Salary: {departmentWithMaxAveragesalary}");
            return departmentWithMaxAveragesalary;
        }
    }

    class Employee
    {
        public Employee(string name, decimal salary, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Department = department;

        }

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public string Department { get; set; }
    }
}
