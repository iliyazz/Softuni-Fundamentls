using System;
using System.Collections.Generic;
using System.Linq;

namespace P03PhoneShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phones = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] cmdArg = command.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (cmdArg[0])
                {
                    case "Add":
                        if (!phones.Contains(cmdArg[1]))
                        {
                            phones.Add(cmdArg[1]);
                        }
                        break;
                    case "Remove":
                        if (phones.Contains(cmdArg[1]))
                        {
                            phones.Remove(cmdArg[1]);
                        }
                        break;
                    case "Bonus phone":
                        string[] phoneReplacenemt = cmdArg[1].Split(":", StringSplitOptions.RemoveEmptyEntries).ToArray();
                        string oldPhone = phoneReplacenemt[0];
                        string newPhone = phoneReplacenemt[1];
                        if (phones.Contains(oldPhone))
                        {
                            int index = phones.IndexOf(oldPhone);
                            phones.Insert(index + 1, newPhone);
                        }
                        break;
                    case "Last":
                        if (phones.Contains(cmdArg[1]))
                        {
                            phones.Remove(cmdArg[1]);
                            phones.Add(cmdArg[1]);
                        }
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
