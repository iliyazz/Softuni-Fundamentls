using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string sentence = Console.ReadLine();
            List<string> sentenceStr = sentence.ToCharArray().Select(c => c.ToString()).ToList();
            int[] digitSum = new int[numbers.Count];
            for (int i = 0; i < numbers.Count; i++)
            {
                int sum = 0;
                int currentDigit = numbers[i];
                while (currentDigit != 0)
                {

                    sum += currentDigit % 10;
                    currentDigit /= 10;
                }
                digitSum[i] = sum;
            }
            for (int i = 0; i < digitSum.Length; i++)
            {
                if (digitSum[i] > sentenceStr.Count)
                {
                    digitSum[i] %= sentenceStr.Count;
                }
                string currentLetter = sentenceStr[digitSum[i]];
                sentenceStr.RemoveAll(x => x == currentLetter);
            }
            Console.WriteLine(string.Join("",sentenceStr));
        }
    }
}
