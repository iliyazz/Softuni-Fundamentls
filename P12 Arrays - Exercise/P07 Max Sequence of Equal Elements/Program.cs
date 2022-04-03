using System;

namespace P07_Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] element = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int numberOfSequence = 1;
            int numberOfMaxSequence = 1;
            string sequenceStr = element[0];
            for (int i = 0; i < element.Length-1; i++)
            {
                if (element[i] == element[i+1])
                {
                    numberOfSequence++;
                    if (numberOfSequence >numberOfMaxSequence)
                    {
                        numberOfMaxSequence = numberOfSequence;
                        sequenceStr = element[i];
                    }
                }
                else
                {
                    numberOfSequence = 1;
                }
            }
            for (int i = 0; i < numberOfMaxSequence; i++)
            {
                Console.Write($"{sequenceStr} ");
            }
        }
    }
}
