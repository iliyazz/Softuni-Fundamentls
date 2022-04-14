using System;
using System.Collections.Generic;
using System.Linq;

namespace P05.ShoppingSpree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] people  = Console
                .ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<Person> person = new List<Person>();

            AddDataPerson(person, people);

            string[] products = Console
                .ReadLine()
                .Split(';', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<Product>  product= new List<Product>();

            AdddataProduct(product, products);
            BuyingProduct(product, person);
            PrintPurchaseData(person);
        }
        static void PrintPurchaseData(List<Person> persons)
        {
            foreach (var item in persons)
            {
                if (item.BagOfProducts.Count == 0)
                {
                    Console.WriteLine($"{item.Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{item.Name} - {string.Join(", ", item.BagOfProducts)}");
                }
            }
        }
        static void BuyingProduct(List<Product> products, List<Person> persons)
        {
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] token = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string personName = token[0];
                string productPname = token[1];
                Person person = persons.FirstOrDefault(x => x.Name == personName);
                Product product = products.FirstOrDefault(x => x.Name == productPname);
                
                if (person.Money < product.Money)
                {
                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                }
                else
                {
                    person.Money -= product.Money;
                    person.BagOfProducts.Add(productPname);
                    Console.WriteLine($"{person.Name} bought {productPname}");
                }
            }
        }

        static void AdddataProduct(List<Product> product, string[] products)
        {
            foreach (string productItem in products)
            {
                string[] currentProduct = productItem
                    .Split("=", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = currentProduct[0];
                decimal money = decimal.Parse(currentProduct[1]);
                product.Add(new Product(name, money));
            }
        }

        static void AddDataPerson(List<Person> person, string[] people)
        {
            foreach (string peopleItem in people)
            {
                string[] currenPerson = peopleItem
                    .Split("=", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = currenPerson[0];
                decimal money = decimal.Parse(currenPerson[1]);
                

                //Person p = new Person();
                //p.Name = name;
                //p.Money = money;
                //person.Add(p);
                person.Add(new Person(name, money));
            }

        }
    }
    class Person
    {
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            this.BagOfProducts = new List<string>();
        }
        //public Person()
        //{
        //    this.BagOfProducts = new List<string>();
        //}

        public string Name { get; set; }

        public decimal Money { get; set; }

        public List<string> BagOfProducts { get; set; }
    }
    class Product
    {
        public Product(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
        }
        public string Name { get; set; }

        public decimal Money { get; set; }

        //public BagOfProducts BagOfCProducts { get; set; }
    }
    
}
