using System;
using System.Collections.Generic;
using System.Linq;

namespace P09_Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> distanceToPokemon = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int index = 0;
            int sum = 0;

            while (distanceToPokemon.Any())
            {
                index = int.Parse(Console.ReadLine());

                sum += CheckIndex(distanceToPokemon, index);

            }
            Console.WriteLine(sum);
        }
        static int CheckIndex(List<int> distanceToPokemon, int index)
        {
            int currentDistance = 0;
            if (index < 0)
            {
                index = 0;
                currentDistance = distanceToPokemon.First();
                RemoveFirstElement(distanceToPokemon, index, currentDistance);
            }
            else if (index > distanceToPokemon.Count - 1)
            {
                index = distanceToPokemon.Count - 1;
                currentDistance = distanceToPokemon.Last();

                RemoveLastElement(distanceToPokemon, index, currentDistance);

            }
            else
            {
                currentDistance = distanceToPokemon[index];
                RemoveInternalElement(distanceToPokemon, index, currentDistance);
            }
                return currentDistance;

        }
        static void RemoveFirstElement(List<int> distanceToPokemon, int index, int currentDistance)
        {
            if (distanceToPokemon.Any())
            {
                distanceToPokemon.RemoveAt(0);
                int current = distanceToPokemon.Last();
                distanceToPokemon.Insert(0, current);
                for (int i = 0; i < distanceToPokemon.Count; i++)
                {
                    if (distanceToPokemon[i] <= currentDistance)
                    {
                        distanceToPokemon[i] += currentDistance;
                    }
                    else
                    {
                        distanceToPokemon[i] -= currentDistance;
                    }
                }
            }
        }
        static void RemoveLastElement(List<int> distanceToPokemon, int index, int currentDistance)
        {
            if (distanceToPokemon.Any())
            {
                distanceToPokemon.RemoveAt(distanceToPokemon.Count - 1);
                int current = distanceToPokemon.First();
                distanceToPokemon.Add(current);
                for (int i = 0; i < distanceToPokemon.Count; i++)
                {
                    if (distanceToPokemon[i] <= currentDistance)
                    {
                        distanceToPokemon[i] += currentDistance;
                    }
                    else
                    {
                        distanceToPokemon[i] -= currentDistance;
                    }
                }
            }
        }
        static void RemoveInternalElement(List<int> distanceToPokemon, int index, int currentDistance)
        {
            if (distanceToPokemon.Any())
            {
                distanceToPokemon.RemoveAt(index);
                for (int i = 0; i < distanceToPokemon.Count; i++)
                {
                    if (distanceToPokemon[i] <= currentDistance)
                    {
                        distanceToPokemon[i] += currentDistance;
                    }
                    else
                    {
                        distanceToPokemon[i] -= currentDistance;
                    }
                }
            }
        }
    }
}
