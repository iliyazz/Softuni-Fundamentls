using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_List_Manipulation_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            bool isMadeChanges = false;
            while (command != "end")
            {
                string[] token = command.Split(' ');
                string action = token[0];
                List<int> currentList = new List<int>(listOfIntegers);

                switch (action)
                {
                    case "Add":
                        listOfIntegers.Add(int.Parse(token[1]));
                        isMadeChanges = true;
                        break;
                    case "Remove":
                        listOfIntegers.Remove(int.Parse(token[1]));
                        isMadeChanges = true;
                        break;
                    case "RemoveAt":
                        listOfIntegers.RemoveAt(int.Parse(token[1]));
                        isMadeChanges = true;
                        break;
                    case "Insert":
                        int index = int.Parse(token[2]);
                        listOfIntegers.Insert(index, int.Parse(token[1]));
                        isMadeChanges = true;
                        break;
                    case "Contains":
                        if (listOfIntegers.Contains(int.Parse(token[1])) == true)
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        currentList.RemoveAll(x => x % 2 != 0);
                        Console.WriteLine(string.Join(" ", currentList));
                        break;
                    case "PrintOdd":
                        currentList.RemoveAll(x => x % 2 == 0);
                        Console.WriteLine(string.Join(" ", currentList));
                        break;
                    case "GetSum":
                        Console.WriteLine(listOfIntegers.Sum());
                        break;
                    case "Filter":
                        string  conditionForFilter = token[1];
                        int numberForCondition = int.Parse(token[2]);
                        Filter(listOfIntegers, conditionForFilter, numberForCondition);
                        break;

                    default:
                        break;
                }
                command = Console.ReadLine();
            }
                if (isMadeChanges == true)

                {
                    Console.WriteLine(string.Join(" ", listOfIntegers));
                }
        }
        static void Filter(List<int> listForFilter, string expressionCond, int numberForCondition)
        {
            List<int> currentListFilter = new List<int>(listForFilter);
            switch (expressionCond)
            {
                case "<":
                    currentListFilter.RemoveAll(x => x >= numberForCondition);
                    break;
                case ">":
                    currentListFilter.RemoveAll(x => x <= numberForCondition);
                    break;
                case ">=":
                    currentListFilter.RemoveAll(x => x < numberForCondition);
                    break;
                case "<=":
                    currentListFilter.RemoveAll(x => x > numberForCondition);
                    break;
                default:
                    break ;
            }
            Console.WriteLine(String.Join(" ", currentListFilter));
        }
    }
}
