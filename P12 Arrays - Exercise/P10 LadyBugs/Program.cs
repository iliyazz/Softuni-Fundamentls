using System;
using System.Linq;

namespace P10_LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfFieldInt = int.Parse(Console.ReadLine());
            int[] arrCurrentIndex = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string direction = string.Empty;
            int[] arrEnd = new int[sizeOfFieldInt];

            for (int i = 0; i < sizeOfFieldInt; i++)
            {
                if (arrCurrentIndex.Contains(i))
                {
                    arrEnd[i] = 1;
                }
            }
            while ((direction = Console.ReadLine()) != "end")
            {
                string[] directionArr = direction.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int ladybugIndex = int.Parse(directionArr[0]);
                string directionOfLadybug = directionArr[1];
                int ladybugflyLength = int.Parse(directionArr[2]);
                if (ladybugIndex >= sizeOfFieldInt || ladybugIndex < 0)
                {
                    continue;
                }
                if (arrEnd[ladybugIndex] == 0)
                {
                    continue;
                }
                arrEnd[ladybugIndex] = 0;
                int nextIndex = ladybugIndex;
                while (true)
                {
                    if (directionOfLadybug == "right")
                    {
                        nextIndex += ladybugflyLength;
                    }
                    else if (directionOfLadybug == "left")
                    {
                        nextIndex -= ladybugflyLength;
                    }
                    if (nextIndex < 0 || nextIndex >= sizeOfFieldInt)
                    {
                        break;
                    }
                    if (arrEnd[nextIndex] == 0)
                    {
                        break;
                    }
                }
                if (nextIndex >= 0 && nextIndex < sizeOfFieldInt)
                {
                    arrEnd[nextIndex] = 1;
                }
            }
            Console.WriteLine(String.Join(" ", arrEnd));
        }
    }
}
