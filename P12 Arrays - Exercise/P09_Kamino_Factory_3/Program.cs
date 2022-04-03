using System;
using System.Linq;

namespace P09_Kamino_Factory_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dnaLenght = int.Parse(Console.ReadLine());
            string currentInput = Console.ReadLine();
            int StartingIndexCurrent = 0;
            int besStartingIndexCurrent = 0;
            int besStartingIndex = 0;
            int lenghOfCurrentSequence = 0;
            int bestLenghOfSequence = 0;
            int currentSum = 0;
            int otherSeqLenght = 0;
            while (currentInput != "Clone them!")
            {
                //int[] bestSequenceArr = new int[dnaLenght];
                int[] currentSequenceArr = new int[dnaLenght];
                currentSequenceArr = currentInput
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int i = 0; i < currentSequenceArr.Length - 1; i++)
                {
                    if (currentSequenceArr[i] == 1)
                    {
                        lenghOfCurrentSequence++;
                    }
                    else
                    {
                        otherSeqLenght = lenghOfCurrentSequence;
                        lenghOfCurrentSequence = 0;
                    }
                    if (lenghOfCurrentSequence > otherSeqLenght)
                    {
                        bestLenghOfSequence = lenghOfCurrentSequence;
                        besStartingIndexCurrent = i -lenghOfCurrentSequence - 1;
                    }
                }
                if (true)
                {

                }
            }
            //Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestArr.Sum()}.");
            //Console.WriteLine(String.Join(" ", bestArr));
            Console.WriteLine(otherSeqLenght);
        }
    }
}
