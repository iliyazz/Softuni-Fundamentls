using System;

namespace P05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantityOfProduct = int.Parse(Console.ReadLine());
            TotalPrice(product, quantityOfProduct);
        }

        static void TotalPrice (string product, int quantityOfProduct)
        {
            const double coffeePrice = 1.50;
            const double waterPrice = 1.00;
            const double cokePrice = 1.40;
            const double snacksPrice = 2.00;
            double price = 0;
            switch (product)
            {
                case "coffee":
                    price = coffeePrice;
                    break;
                case "water":
                    price = waterPrice;
                    break;
                case "coke":
                    price = cokePrice;
                    break;
                case "snacks":
                    price = snacksPrice;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{price * quantityOfProduct:F2}");
        }
    }
}
