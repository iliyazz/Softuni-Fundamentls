using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string commandActoin = commandArg[0];
                int elementCurrent = int.Parse(commandArg[1]);
                if (commandActoin == "Delete")
                {
                    listOfIntegers.RemoveAll(x => x == elementCurrent);
                }
                else if(commandActoin == "Insert")
                {
                    int positoinOfElement = int.Parse(commandArg[2]);
                    listOfIntegers.Insert(positoinOfElement, elementCurrent);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", listOfIntegers));
        }
    }
}
