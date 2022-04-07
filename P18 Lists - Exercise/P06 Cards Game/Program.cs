using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayerCards = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> secondPlayerCards = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            CheckWinner(firstPlayerCards, secondPlayerCards);
            if (secondPlayerCards.Count == 0)
            {
                Console.WriteLine($"First player wins! Sum: {firstPlayerCards.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondPlayerCards.Sum()}");
            }
        }
        static void CheckWinner(List<int> firstPlayerCards, List<int> secondPlayerCards)
        {
            while (!(firstPlayerCards.Count == 0 || secondPlayerCards.Count == 0))
            {
                if (firstPlayerCards[0] == secondPlayerCards[0])
                {
                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.RemoveAt(0);
                }
                else if (firstPlayerCards[0] > secondPlayerCards[0])
                {
                    firstPlayerCards.Add(secondPlayerCards[0]);
                    firstPlayerCards.Add(firstPlayerCards[0]);
                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.RemoveAt(0);
                }
                else
                {
                    secondPlayerCards.Add(firstPlayerCards[0]);
                    secondPlayerCards.Add(secondPlayerCards[0]);
                    firstPlayerCards.RemoveAt(0);
                    secondPlayerCards.RemoveAt(0);

                }
            }
        }
    }
}
