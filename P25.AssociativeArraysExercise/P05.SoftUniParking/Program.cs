using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Dictionary<string, string> users = new Dictionary<string, string>();
            for (int i = 0; i < number; i++)
            {
                string[] tokens = Console
                    .ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string action = tokens[0];
                string username = tokens[1];
                if (action == "register")
                {
                    string licensePlateNumber = tokens[2];

                    Register(users, username, licensePlateNumber);
                }
                else if (action == "unregister")
                {
                    Unregister(users, username);
                }
            }
            foreach (var item in users)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }


        public static void Unregister(Dictionary<string, string> users, string username)
        {
            if (!users.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: user {username} not found");
            }
            else
            {
                users.Remove(username);
                Console.WriteLine($"{username} unregistered successfully");

            }

        }

        public static void Register(Dictionary<string, string> users, string username, string licensePlateNumber)
        {
            if (users.ContainsKey(username))
            {
                Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
            }
            else
            {
                users.Add(username, licensePlateNumber);
                Console.WriteLine($"{username} registered {licensePlateNumber} successfully");

            }
        }
    }
}
