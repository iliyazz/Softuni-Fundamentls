using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();
            for (int i = 0; i < numberOfCommands; i++)
            {
                string command = Console.ReadLine();
                string[] guestStatus = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (guestStatus.Length == 3)
                {
                    AddPerson(guestList, guestStatus);
                }
                else
                {
                    RemovePerson(guestList, guestStatus);
                }
            }
            foreach (var item in guestList)
            {
                Console.WriteLine(item);
            }
        }

        static void AddPerson(List<string> guestList, string[] guestStatus)
        {
            string guestName = guestStatus[0];
                if (!guestList.Contains(guestName))
                {
                    guestList.Add(guestName);
                    return;
                }
                Console.WriteLine($"{guestName} is already in the list!");
                return;
        }
        static void RemovePerson(List<string> guestList, string[] guestStatus)
        {
            string guestName = guestStatus[0];
            {
                if (!guestList.Contains(guestName))
                {
                    Console.WriteLine($"{guestName} is not in the list!");
                    return ;
                }
                guestList.Remove(guestName);
                return ;
            }
        }
    }
}
