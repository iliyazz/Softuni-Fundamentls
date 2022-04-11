using System;
using System.Collections.Generic;
using System.Linq;

namespace P02FriendListMaintenance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> friends = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();
            while (command != "Report")
            {
                string[] cmdArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = string.Empty;
                int index = 0;
                switch (cmdArg[0])
                {
                    case "Blacklist":
                        name = cmdArg[1];
                        if (!friends.Contains(name))
                        {
                            Console.WriteLine($"{name} was not found.");
                        }
                        else
                        {
                            index = friends.IndexOf(name);
                            friends[index] = "Blacklisted";
                            Console.WriteLine($"{name} was blacklisted.");
                        }
                        break;
                    case "Error":
                        index = int.Parse(cmdArg[1]);
                        if (index >= 0 && index < friends.Count)
                        {
                            if (!(friends[index] == "Blacklisted" || friends[index] == "Lost"))
                            {
                            Console.WriteLine($"{friends[index]} was lost due to an error.");
                            friends[index] = "Lost";
                            }
                        }

                        break;
                    case "Change":
                        index = int.Parse(cmdArg[1]);
                        name = cmdArg[2];
                        if (index >= 0 && index < friends.Count)
                        {
                            Console.WriteLine($"{ friends[index]} changed his username to {name}.");
                            friends[index] = name;
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            int countBlaklist = 0;
            int countLostName = 0;
            foreach (var item in friends)
            {
                if (item == "Blacklisted")
                {
                    countBlaklist++;
                }
                else if (item == "Lost")
                {
                    countLostName++;
                }
            }
            Console.WriteLine($"Blacklisted names: {countBlaklist}");
            Console.WriteLine($"Lost names: {countLostName}");
            Console.WriteLine(string.Join(" ", friends));
        }
    }
}
