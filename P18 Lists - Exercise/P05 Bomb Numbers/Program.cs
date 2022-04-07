using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            int[] bombArg = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int bombNumber = bombArg[0];
            int bombPower = bombArg[1];
            while (numbersList.Contains(bombNumber))
            {
                int indexOfFirstBombedArea = numbersList.IndexOf(bombNumber) - bombPower;
                int currentBombPowerIndex = bombPower;
                if (indexOfFirstBombedArea < 0)
                {
                    indexOfFirstBombedArea = 0;
                }
                if (indexOfFirstBombedArea + bombPower * 2 + 1 >= numbersList.Count)
                {
                    currentBombPowerIndex = numbersList.Count - indexOfFirstBombedArea;
                }
                else
                {
                    currentBombPowerIndex = bombPower * 2 + 1;
                }
                numbersList.RemoveRange(indexOfFirstBombedArea, currentBombPowerIndex);
            }
            Console.WriteLine(numbersList.Sum());
        }
    }
}
