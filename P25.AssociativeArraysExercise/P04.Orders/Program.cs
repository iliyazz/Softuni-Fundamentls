using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,Product> products = new Dictionary<string,Product>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "buy")
            {
                string[] tokens = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = tokens[0];
                decimal price = decimal.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);
                Product product = new Product(name, price, quantity);
                if (!products.ContainsKey(name))
                {
                    products.Add(name, product);
                }
                else
                {
                    products[name].Quantity += quantity;
                    if (products[name].Price != price)
                    {
                        products[name].Price = price;
                    }
                }
            }
            foreach (var item in products)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Quantity * item.Value.Price:F2}");
            }
        }
    }
    class Product
    {
        public Product(string name, decimal price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
