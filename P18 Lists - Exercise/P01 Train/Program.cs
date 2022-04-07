using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> trainWagons = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int wagonMaxCapacity = int.Parse(Console.ReadLine());
            string strArgs = Console.ReadLine();
            while (strArgs != "end")
            {
                string[] commandArg = strArgs.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string addCommand = commandArg[0];
                if (addCommand == "Add")
                {
                    trainWagons.Add(int.Parse(commandArg[1]));
                }
                else
                {
                    int passengers = int.Parse(addCommand);
                    FillWagon(trainWagons, passengers, wagonMaxCapacity);
                }

                strArgs = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", trainWagons));
        }
        static void FillWagon(List<int> trainWagons, int passengers, int wagonMaxCapacity)
        {
            for (int i = 0; i < trainWagons.Count; i++)
            {
                if (wagonMaxCapacity >= trainWagons[i] + passengers)
                {
                    trainWagons[i] += passengers;
                    break;
                }
            }
        }
    }
}
