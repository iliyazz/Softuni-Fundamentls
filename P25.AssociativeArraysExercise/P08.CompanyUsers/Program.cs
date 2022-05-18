using System;
using System.Collections.Generic;
using System.Linq;


namespace P08.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> company = new Dictionary<string, List<string>>();
            
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] token = command
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string companyName = token[0];
                string employee = token[1];
                if (!company.ContainsKey(companyName))
                {
                    company.Add(companyName, new List<string>());
                }
                if (!company[companyName].Contains(employee))
                {
                    company[companyName].Add(employee);
                }
                command = Console.ReadLine();
            }
            foreach (var kvp in company)
            {
                Console.WriteLine($"{kvp.Key}");
                foreach (var employee in kvp.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
