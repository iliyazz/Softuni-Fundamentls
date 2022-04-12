using System;
using System.Collections.Generic;
using System.Linq;

namespace P07VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            Catalog catalogObjects = new Catalog();
            while (command != "end")
            {
                string[] tokens = command.Split('/', StringSplitOptions.RemoveEmptyEntries);
                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];
                int hpOrWeight = int.Parse(tokens[3]);
                if (type == "Car")
                {
                    Car currentCar = new Car(brand, model, hpOrWeight);
                    catalogObjects.Cars.Add(currentCar);

                }
                else if (type == "Truck")
                {
                    Truck currentTruck = new Truck(brand, model, hpOrWeight);
                    catalogObjects.Trucks.Add(currentTruck);
                }

                command = Console.ReadLine();
            }

            if (catalogObjects.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                List<Car> orderedCars = catalogObjects.Cars.OrderBy(x => x.Brand).ToList();
                foreach (Car item in orderedCars)
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
                }
            }

            if (catalogObjects.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                List<Truck> orderedTrucks = catalogObjects.Trucks.OrderBy(x => x.Brand).ToList();
                foreach (Truck item in orderedTrucks)
                {
                    Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
                }
            }

        }
    }
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }
    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }
    class Catalog
    {
        public Catalog()
        {
            this.Trucks = new List<Truck>();
            this.Cars = new List<Car>();
        }
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
    }
}
