using System;

namespace P01_Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int countOfnumber = 3;
            int[] arrOfNumberes = new int[countOfnumber];

            for (int i = 0; i < countOfnumber; i++)
            {
                arrOfNumberes[i] = int.Parse(Console.ReadLine());
            }
            SmallestNumber(arrOfNumberes);
        }
        static void SmallestNumber(int[] arrOfNumbers)
        {
            int[] sortedArr = new int[arrOfNumbers.Length];
            arrOfNumbers.CopyTo(sortedArr, 0);
            for (int i = 0; i < sortedArr.Length - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < sortedArr.Length; j++)
                {
                    if (sortedArr[j] < sortedArr[maxIndex])
                    {
                        maxIndex = j;
                    }
                }
                int oldNumber = sortedArr[i];
                sortedArr[i] = sortedArr[maxIndex];
                sortedArr[maxIndex] = oldNumber;
            }
            //for (int i = 0; i < sortedArr.Length - 1; i++)
            //{
            //    int minIndex = i;
            //    for (int j = i + 1; j < sortedArr.Length; j++)
            //    {
            //        if (sortedArr[j] > sortedArr[minIndex])
            //        {
            //            minIndex = j;
            //        }
            //    }
            //    int oldNumber = sortedArr[i];
            //    sortedArr[i] = sortedArr[minIndex];
            //    sortedArr[minIndex] = oldNumber;
            //}
            //for (int i = 0; i < sortedArr.Length; i++)
            //{
            //    Console.WriteLine(sortedArr[i]);
            //}
            Console.WriteLine(sortedArr[0]);
        }
    }
}
