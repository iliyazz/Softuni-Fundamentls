using System;

namespace P09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long daylyExtractedSpices = int.Parse(Console.ReadLine());
            long totalAmountOfSpice = 0;
            long currentAmmountOfSpice = 0;
            const int ConsumeFromWorkers = 26;
            const int YeldDrop = 10;
            long days = 0;
            if (daylyExtractedSpices < 100)
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
            }
            else
            {
                do
                {
                    days++;
                    currentAmmountOfSpice = daylyExtractedSpices - ConsumeFromWorkers;
                    daylyExtractedSpices -= YeldDrop;
                    totalAmountOfSpice += currentAmmountOfSpice;


                } while (daylyExtractedSpices >= 100);
                Console.WriteLine(days);
                Console.WriteLine(totalAmountOfSpice - ConsumeFromWorkers);

            }
        }
    }
}
