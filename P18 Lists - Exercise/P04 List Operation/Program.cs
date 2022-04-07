using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_List_Operation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfInteger = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] commandArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string currentComand = commandArg[0];
                switch (currentComand)
                {
                    case "Add":
                        listOfInteger.Add(int.Parse(commandArg[1]));
                        break;
                    case "Insert":
                        if (int.Parse(commandArg[2]) < 0 || int.Parse(commandArg[2]) >= listOfInteger.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        listOfInteger.Insert(int.Parse(commandArg[2]), int.Parse(commandArg[1]));
                        break;
                    case "Remove":
                        if (int.Parse(commandArg[1]) < 0 || int.Parse(commandArg[1]) >= listOfInteger.Count)
                        {
                            Console.WriteLine("Invalid index");
                            break;
                        }
                        listOfInteger.RemoveAt(int.Parse(commandArg[1]));
                        break;
                    case "Shift":
                        int numberOfShift = int.Parse(commandArg[2]);
                        if (commandArg[1] == "left")
                        {
                            ShiftLeft(listOfInteger, numberOfShift);
                        }
                        else
                        {
                            ShiftRight(listOfInteger, numberOfShift);
                        }
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", listOfInteger));
        }
        static void ShiftLeft(List<int> listOfInteger, int numberOfShift)
        {
            for (int i = 0; i < numberOfShift; i++)
            {
                int currentNumber = listOfInteger.First();
                listOfInteger.RemoveAt(0);
                listOfInteger.Add(currentNumber);
            }
        }
        static void ShiftRight(List<int> listOfInteger, int numberOfShift)
        {
            for (int i = 0; i < numberOfShift; i++)
            {
                int currentNimber = listOfInteger.Last();
                listOfInteger.Remove(listOfInteger.Last());
                listOfInteger.Insert(0, currentNimber);
            }
        }
    }
}
