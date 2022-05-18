using System;
using System.Collections.Generic;

namespace P02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resource = string.Empty;
            Dictionary<string, ulong> minerTask = new Dictionary<string, ulong>();
            while ((resource = Console.ReadLine()) != "stop")
            {
                ulong quantity = ulong.Parse(Console.ReadLine());
                if (minerTask.ContainsKey(resource))
                {
                    minerTask[resource] += quantity;
                }
                else
                {
                    minerTask.Add(resource, quantity);
                }
            }
            foreach (var item in minerTask)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
