using System;
using System.Linq;

namespace P11_Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArr = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string commandType = cmdArr[0];
                switch (commandType)
                {
                    case "exchange":
                        int index = int.Parse(cmdArr[1]);

                        if (index < 0 || index >= inputArr.Length)
                        {
                            Console.WriteLine("Invalid index");
                            continue;
                        }
                        inputArr = ExchangeCommand(inputArr, index);
                        break;


                    case "max":
                        string maxEvenOrOdd = cmdArr[1];
                        int maxIndex = GetMaxEvenOrOddIndex(inputArr, maxEvenOrOdd);
                        if (maxIndex == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(maxIndex);
                        }

                        break;


                    case "min":
                        string minEvenOrOdd = cmdArr[1];
                        int minIndex = GetMinEvenOrOddIndex(inputArr, minEvenOrOdd);
                        if (minIndex == -1)
                        {
                            Console.WriteLine("No matches");
                        }
                        else
                        {
                            Console.WriteLine(minIndex);
                        }
                        break;


                    case "first":
                        int firstCount = int.Parse(cmdArr[1]);
                        string firstEvenOrOdd = cmdArr[2];
                        if (firstCount > inputArr.Length)
                        {
                            Console.WriteLine("Invalid count");
                            continue;
                        }
                        else
                        {
                            int[] arrCur = GetFirstEvenOrOddElements(inputArr, firstCount, firstEvenOrOdd);
                        }
                        break;


                    case "last":
                        int lastCount = int.Parse(cmdArr[1]);
                        string lastEvenOrOdd = cmdArr[2];
                        if (lastCount > inputArr.Length)
                        {
                            Console.WriteLine("Invalid count");
                            continue;
                        }
                        else
                        {
                            int[] arrCur = GetlastEvenOrOddElements(inputArr, lastCount, lastEvenOrOdd);
                        }
                        break;
                    default:
                        break;
                }
            }
            Console.Write("[");
            for (int i = 0; i < inputArr.Length; i++)
            {
                if (i == inputArr.Length - 1)
                {
                    Console.Write($"{inputArr[i]}");
                }
                else
                {
                    Console.Write($"{inputArr[i]}, ");
                }
            }
            Console.WriteLine("]");
        }
        static int[] ExchangeCommand(int[] inputArr, int index)
        {
            int[] currentArr = new int[inputArr.Length];
            int counter = 0;
            for (int i = index + 1; i < inputArr.Length; i++)
            {
                currentArr[counter] = inputArr[i];
                counter++;
            }
            for (int i = 0; i <= index; i++)
            {
                currentArr[counter] = inputArr[i];
                counter++;
            }
            return currentArr;
        }
        static int GetMaxEvenOrOddIndex(int[] inputArr, string maxEvenOrOdd)
        {
            int maxElement = int.MinValue;
            int indexOfElementMax = -1;
            if (maxEvenOrOdd == "even")
            {
                for (int i = 0; i < inputArr.Length; i++)
                {

                    if (inputArr[i] >= maxElement && inputArr[i] % 2 == 0)
                    {
                        maxElement = inputArr[i];
                        indexOfElementMax = i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < inputArr.Length; i++)
                {

                    if (inputArr[i] >= maxElement && inputArr[i] % 2 != 0)
                    {
                        maxElement = inputArr[i];
                        indexOfElementMax = i;
                    }
                }
            }
            return indexOfElementMax;
        }
        static int GetMinEvenOrOddIndex(int[] inputArr, string minEvenOrOdd)
        {
            int minElement = int.MaxValue;
            int indexOfElementMin = -1;
            if (minEvenOrOdd == "even")
            {
                for (int i = 0; i < inputArr.Length; i++)
                {

                    if (inputArr[i] <= minElement && inputArr[i] % 2 == 0)
                    {
                        minElement = inputArr[i];
                        indexOfElementMin = i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < inputArr.Length; i++)
                {

                    if (inputArr[i] <= minElement && inputArr[i] % 2 != 0)
                    {
                        minElement = inputArr[i];
                        indexOfElementMin = i;
                    }
                }
            }
            return indexOfElementMin;
        }
        static int[] GetFirstEvenOrOddElements(int[] inputArr, int firstCount, string firstEvenOrOdd)
        {
            int[] currentFirstEvenOrOddElements = new int[firstCount];
            int count = 0;
            if (firstEvenOrOdd == "even")
            {
                for (int i = 0; i < inputArr.Length; i++)
                {
                    if (inputArr[i] % 2 == 0 && count < firstCount)
                    {
                        currentFirstEvenOrOddElements[count++] = inputArr[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < inputArr.Length; i++)
                {
                    if (inputArr[i] % 2 != 0 && count < firstCount)
                    {
                        currentFirstEvenOrOddElements[count++] = inputArr[i];
                    }
                }
            }
            ////////////////////////////////////////////////////////
            Console.Write("[");
            for (int i = 0; i < count; i++)
            {
                if (i == currentFirstEvenOrOddElements.Length - 1)
                {
                    Console.Write($"{currentFirstEvenOrOddElements[i]}");
                }
                else
                {
                    Console.Write($"{currentFirstEvenOrOddElements[i]}, ");
                }
            }
            Console.WriteLine("]");
            return currentFirstEvenOrOddElements;
        }
        /// <summary>
        /// //////////////////
        /// </summary>
        /// <param name="inputArr"></param>
        /// <param name="lastCount"></param>
        /// <param name="lastEvenOrOdd"></param>
        /// <returns></returns>
        static int[] GetlastEvenOrOddElements(int[] inputArr, int lastCount, string lastEvenOrOdd)
        {
            int[] currentLastEvenOrOddElements = new int[inputArr.Length];
            int count = 0;
            if (lastEvenOrOdd == "even")
            {
                for (int i = inputArr.Length - 1; i >= 0; i--)
                {
                    if (inputArr[i] % 2 == 0 && count < lastCount)
                    {
                        currentLastEvenOrOddElements[count++] = inputArr[i];
                    }
                }
            }
            else
            {
                for (int i = inputArr.Length - 1; i >= 0; i--)
                {
                    if (inputArr[i] % 2 != 0 && count < lastCount)
                    {
                        currentLastEvenOrOddElements[count++] = inputArr[i];
                    }
                }
            }
            //////////////////////////////////////////////////////
            Console.Write("[");
            for (int i = 0; i < count; i++)
            {
                if (i == currentLastEvenOrOddElements.Length - 1)
                {
                    Console.Write($"{currentLastEvenOrOddElements[i]}");
                }
                else
                {
                    Console.Write($"{currentLastEvenOrOddElements[i]}, ");
                }
            }
            Console.WriteLine("]");
            return currentLastEvenOrOddElements;
        }
    }
}
