using System;
using System.Linq;

namespace _09_Kamino_Factory_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());

            int[] bestArr = new int[dnaLength];
            int minStartinIndex = dnaLength;
            int numberOfAllMaxSequence = 0;
            int bestSum = 0;
            int bestSample = 1;

            string command = Console.ReadLine();
            int counter = 0;

            while (command != "Clone them!")
            {
                int[] currentSequenceArr = command.Split("!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                counter++;

                int currentSequenceLenght = 0;
                int previousSequenceLenght = 0;
                int numberOfMaxSequence = 0;

                int leftStartingIndex = dnaLength;

                int currentSampleSum = 0;

                for (int i = 0; i < currentSequenceArr.Length; i++)
                {
                    if (currentSequenceArr[i] == 1)
                    {
                        currentSequenceLenght++;
                        currentSampleSum++;
                    }
                    else
                    {
                        previousSequenceLenght = currentSequenceLenght;
                        currentSequenceLenght = 0;
                    }

                    if (currentSequenceLenght > previousSequenceLenght)
                    {
                        numberOfMaxSequence = currentSequenceLenght;
                        leftStartingIndex = i - currentSequenceLenght + 1;
                    }
                }

                if (numberOfMaxSequence > numberOfAllMaxSequence)
                {
                    numberOfAllMaxSequence = numberOfMaxSequence;
                    minStartinIndex = leftStartingIndex;
                    bestArr = currentSequenceArr;
                    bestSample = counter;
                    bestSum = currentSampleSum;
                }
                else if (numberOfMaxSequence == numberOfAllMaxSequence)
                {
                    if (leftStartingIndex < minStartinIndex)
                    {
                        minStartinIndex = leftStartingIndex;
                        bestSum = currentSampleSum;
                        bestArr = currentSequenceArr;
                        bestSample = counter;
                    }
                    else if (minStartinIndex == leftStartingIndex)
                    {
                        if (currentSampleSum > bestSum)
                        {
                            bestSum = currentSampleSum;
                            bestArr = currentSequenceArr;
                            bestSample = counter;
                        }
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSum}.");
            Console.WriteLine(string.Join(" ", bestArr));

        }
    }
}
