using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] token = command.Split(' ');
                string action = token[0];
                int number = int.Parse(token[1]);
                switch (action)
                {
                    case "Add":
                        listOfIntegers.Add(number);
                        break;
                    case "Remove":
                        listOfIntegers.Remove(number);
                        break;
                    case "RemoveAt":
                        listOfIntegers.RemoveAt(number);
                        break;
                    case "Insert":
                int index = int.Parse(token[2]);
                        listOfIntegers.Insert(index, number);
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", listOfIntegers));
        }
    }
}
