using System;
using System.Linq;

namespace P09_Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dnaLenght = int.Parse(Console.ReadLine());
            int[] bestArr = new int[dnaLenght];
            int minStartinIndex = 0;
            int numberOfAllMaxSequence = 0;
            int bestSample = 1;
            int counter = 0;
            int bestSum = 0;
            string currentInput = Console.ReadLine();
            while (currentInput != "Clone them!")
            {
                int leftStartingIndex = 0;
                int numberOfSequence = 0;
                int numberOfMaxSequence = 0;
                int[] currentSequenceArr = new int[dnaLenght];
                int currentSum = 0;

                currentSequenceArr = currentInput
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                counter++;

                for (int i = 0; i < currentSequenceArr.Length - 1; i++)
                {
                    if (currentSequenceArr[i] == currentSequenceArr[i + 1] && currentSequenceArr[i] == 1)
                    {
                        numberOfSequence++;
                        if (numberOfSequence > numberOfMaxSequence)
                        {
                            leftStartingIndex = i - numberOfSequence + 1;
                            numberOfMaxSequence = numberOfSequence;

                        }
                    }
                    else
                    {
                        numberOfSequence = 0;
                    }
                }
                currentSum = currentSequenceArr.Sum();
                if (numberOfMaxSequence > numberOfAllMaxSequence)
                {
                    numberOfAllMaxSequence = numberOfMaxSequence;
                    minStartinIndex = leftStartingIndex;
                    bestArr = currentSequenceArr;
                    bestSample = counter;
                    bestSum = currentSum;
                }
                else if (numberOfAllMaxSequence == numberOfMaxSequence)
                {
                    if (minStartinIndex > leftStartingIndex)
                    {
                        minStartinIndex = leftStartingIndex;
                        bestSum = currentSum;
                        bestArr = currentSequenceArr;
                        bestSample = counter;
                    }
                    else if (minStartinIndex == leftStartingIndex)
                    {
                        if (currentSum > bestSum)
                        {
                            bestSum = currentSum;
                            bestArr = currentSequenceArr;
                            bestSample = counter;
                        }
                    }
                }
                currentInput = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestArr.Sum()}.");
            Console.WriteLine(String.Join(" ", bestArr));
        }
    }
}
