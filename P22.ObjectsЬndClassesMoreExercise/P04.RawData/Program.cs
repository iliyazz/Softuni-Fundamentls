using System;
using System.Collections.Generic;
using System.Linq;

namespace P04.RawData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < number; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                int engineSpeed = int.Parse(tokens[1]);
                int enginePower = int.Parse(tokens[2]);
                int cargoWeght = int.Parse(tokens[3]);
                string cargoType = tokens[4];
                Engine engine = new Engine();
                engine.EngineSpeed = engineSpeed;
                engine.EnginePower = enginePower;
                Cargo cargo = new Cargo();
                cargo.CargoType = cargoType;
                cargo.CargoWeght = cargoWeght;
                Car car = new Car(model, engine, cargo);
                cars.Add(car);
                
            }
            string command = Console.ReadLine();
            if (command == "fragile")
            {
                Fragile(cars);
            }
            else if (command == "flamable")
            {
                Flamable(cars);
            }
        }

        static void Fragile(List<Car> cars)
        {
            foreach (var item in cars)
            {
                if (item.Cargo.CargoType == "fragile" && item.Cargo.CargoWeght <1000)
                {
                    Console.WriteLine($"{item.Model}");
                }
            }
        }
        static void Flamable(List<Car> cars)
        {
            foreach (var item in cars)
            {
                if (item.Cargo.CargoType == "flamable" && item.Engine.EnginePower > 250)
                {
                    Console.WriteLine($"{item.Model}");
                }
            }

        }
    }

    class Car
    {
        public Car(string model, Engine engine, Cargo cargo)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;

        }
        public string Model { get; set; }
        
        public Engine Engine {get; set;}
        
        public Cargo Cargo { get; set; }

        
    }
    class Engine
    {
        public int EngineSpeed { get; set; }

        public int EnginePower { get; set; }
    }
    class Cargo
    {
        public int CargoWeght { get; set; }

        public string CargoType { get; set; }

    }
}
