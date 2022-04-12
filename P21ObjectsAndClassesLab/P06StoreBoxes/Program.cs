using System;
using System.Collections.Generic;
using System.Linq;

namespace P06StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Box> boxes = new List<Box>();
            while (command != "end")
            {
                string[] token = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string itemSerialNumber = token[0];
                string itemName = token[1];
                int itemQuantity = int.Parse(token[2]);
                decimal itemPrice = decimal.Parse(token[3]);
                Box box = new Box()
                {
                    SerialNumber = itemSerialNumber,
                    Item = new Item()
                    {
                        Name = itemName,
                        Price = itemPrice
                    },
                    Quantity = itemQuantity,
                };
                boxes.Add(box);

                command = Console.ReadLine();
            }
            List<Box> orderedBoxes = boxes.OrderByDescending(x => x.PriceForBox).ToList();
            foreach (Box item in orderedBoxes)
            {
                Console.WriteLine($"{item.SerialNumber}");
                Console.WriteLine($"-- {item.Item.Name} - ${item.Item.Price:F2}: {item.Quantity}");
                Console.WriteLine($"-- ${item.PriceForBox:F2}");
            }

        }
    }

    class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
    class Box
    {
        public Box()
        {
            Item = new Item();
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
        public decimal PriceForBox
        { 
            get
            {
                return this.Quantity * this.Item.Price;
            }
        }
    }

}
