using System;

namespace P01BurgerBus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCities = int.Parse(Console.ReadLine());
            double profit = 0;
            double totalProfit = 0;
            for (int i = 1; i <= numberOfCities; i++)
            {
            string cityName = Console.ReadLine();
            double income = double.Parse(Console.ReadLine());
            double expenses = double.Parse(Console.ReadLine());

                if (i % 5 == 0 )
                {
                    profit = (income * 0.9 - expenses);
                    totalProfit += profit;
                }
                else if (i % 3 == 0)
                {
                    profit = income - expenses * 1.5;
                    totalProfit += profit;
                }
                else
                {
                    profit = income - expenses;
                    totalProfit += profit;
                }
                Console.WriteLine($"In {cityName} Burger Bus earned {profit:F2} leva.");
            }
            Console.WriteLine($"Burger Bus total profit: {totalProfit:F2} leva.");
        }
    }
}
