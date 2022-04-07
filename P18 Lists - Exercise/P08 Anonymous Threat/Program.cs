using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P08_Anonymous_Threat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            string command = Console.ReadLine();
            while (command != "3:1")
            {
                string[] commandArg = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (commandArg[0] == "merge")
                {
                    int startIndex = int.Parse(commandArg[1]);
                    int endIndex = int.Parse(commandArg[2]);
                    MergeCommand(inputData, startIndex, endIndex);
                }
                else if (commandArg[0] == "divide")
                {
                    int index = int.Parse(commandArg[1]);
                    int partitions = int.Parse(commandArg[2]);
                    DivideCommand(inputData, index, partitions);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", inputData));
        }
        static void MergeCommand(List<string> inputData, int startIndex, int endIndex)
        {
            if (startIndex < 0)
            {
                startIndex = 0;
            }
            else if(startIndex >= inputData.Count)
            {
                return;
            }
            if (endIndex >= inputData.Count)
            {
                endIndex = inputData.Count - 1;
            }
            else if(endIndex < 0)
            {
                return;
            }
            int count = endIndex - startIndex +1;
            StringBuilder currentTextBuilder = new StringBuilder();
            for(int i = startIndex; i <= endIndex; i++)
            {
                currentTextBuilder.Append(inputData[i]);
            }
            inputData.RemoveRange(startIndex, count);
            inputData.Insert(startIndex, currentTextBuilder.ToString());
        }
        static void DivideCommand(List<string> inputData, int index, int partitions)
        {
            if (index < 0)
            {
                index = 0;
            }
            else if (index >= inputData.Count)
            {
                return;
            }
            string currentText = inputData[index];
            int textLenght = currentText.Length;
            int strDividedLength = textLenght / partitions;
            int strDividedLengthRemainder = textLenght % partitions;
            int startIndex = 0;
            string[] currentArr = new string[partitions];
            for (int i = 0; i < partitions; i ++)
            {
                string currentWord = currentText.Substring(startIndex, strDividedLength);
                currentArr[i] = currentWord;

                startIndex += strDividedLength;
                if (i == partitions-2)
                {
                    strDividedLength += strDividedLengthRemainder;
                }
            }
            inputData.RemoveAt(index);
            inputData.InsertRange(index, currentArr);
        }
    }
}
