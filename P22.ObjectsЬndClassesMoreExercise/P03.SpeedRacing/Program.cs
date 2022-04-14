using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.SpeedRacing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            InputData(cars);
            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] tokens = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string carModel = tokens[1];
                double amountOfKm = double.Parse(tokens[2]);
                
                Car.CheckCarFuel(cars, carModel, amountOfKm);

                command = Console.ReadLine();
            }

            foreach (Car item in cars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:F2} {item.TraveledDistance}");
            }

        }
        static void InputData(List<Car> cars)
        {
            int numberOfcars = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfcars; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string currentModel = tokens[0];
                double currentFuelAmount = double.Parse(tokens[1]);
                double fuelRate = double.Parse(tokens[2]);
                double traveletDistance = 0;
                Car currentCar = new Car(
                    currentModel,
                    currentFuelAmount,
                    fuelRate,
                    traveletDistance);

                cars.Add(currentCar);
            }

        }
    }
    class Car
    {
        public Car(string model, double fuelAmount, double fuelRate, double traveledDistance)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelRate = fuelRate;
            this.TraveledDistance = traveledDistance;
            
        }
        public string Model { get; set; }

        public double FuelAmount { get; set; }

        public double FuelRate { get; set; }

        public double TraveledDistance { get; set; }

        public static void CheckCarFuel(List<Car> cars, string carModel, double amountOfKm)
        {
            
            string checkedCarModel = carModel;
            double fuelAmountCur = cars.FirstOrDefault(x => x.Model == carModel).FuelAmount;
            double fuelrateCur = cars.FirstOrDefault(x => x.Model == carModel).FuelRate;
            double neededFuel = fuelrateCur * amountOfKm;
            if (neededFuel > fuelAmountCur)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                cars.FirstOrDefault(x => x.Model == carModel).FuelAmount -= neededFuel;
                cars.FirstOrDefault(x => x.Model == carModel).TraveledDistance += amountOfKm;

            }
        }
    }
}
