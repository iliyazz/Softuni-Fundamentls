using System;
using System.Linq;

namespace proba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, };
            bool isContain = arr.Contains(7);
            Console.WriteLine(isContain);
        }
    }
}
