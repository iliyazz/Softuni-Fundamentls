using System;
using System.Collections.Generic;
using System.Linq;

namespace P06.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            List<Catalogue> catalogList = new List<Catalogue>();
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArg = command.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string typeOfVehicle = cmdArg[0];
                string model = cmdArg[1];
                string color = cmdArg[2];
                double horsepower = double.Parse(cmdArg[3]);
                Catalogue current = new Catalogue(typeOfVehicle, model, color, horsepower);
                catalogList.Add(current);
            }
            string searchVehicle = Console.ReadLine();
            while (searchVehicle != "Close the Catalogue")
            {
                PrintVehivle(catalogList, searchVehicle);

                searchVehicle = Console.ReadLine();
            }
            PrinAverageHp(catalogList);
        }

        private static void PrinAverageHp(List<Catalogue> catalogList)
        {
            double averageCarHp = 0;

            if (catalogList.FirstOrDefault(x => x.TypeOfVehicle == "car") != null)
            {
                averageCarHp = (double)catalogList
                    .Where(x => x.TypeOfVehicle == "car")
                    .Select(x => x.Horsepower)
                    .Sum()
                    / (double)catalogList
                    .Where(x => x.TypeOfVehicle == "car")
                    .Count(x => x.TypeOfVehicle == "car");
                Console.WriteLine($"Cars have average horsepower of: {averageCarHp:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {averageCarHp:F2}.");
            }

            double averageTruckHp = 0;
            if (catalogList.FirstOrDefault(x => x.TypeOfVehicle == "truck") != null)
            {


                averageTruckHp = (double)catalogList
                .Where(x => x.TypeOfVehicle == "truck")
                .Select(x => x.Horsepower)
                .Sum() / (double)catalogList
                .Where(x => x.TypeOfVehicle == "truck")
                .Count(x => x.TypeOfVehicle == "truck");
                Console.WriteLine($"Trucks have average horsepower of: {averageTruckHp:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageTruckHp:F2}.");
            }
        }

        private static void PrintVehivle(List<Catalogue> catalogList, string searchVehicle)
        {
            Catalogue current = catalogList.FirstOrDefault(x => x.Model == searchVehicle);
            if (current == null)
            {
                return;
            }
            else
            {
                string capitalizeFirstletter = char.ToUpper(current.TypeOfVehicle.First()) + current.TypeOfVehicle.Substring(1).ToLower();
                Console.WriteLine($"Type: {capitalizeFirstletter}");
                Console.WriteLine($"Model: {current.Model}");
                Console.WriteLine($"Color: {current.Color}");
                Console.WriteLine($"Horsepower: {current.Horsepower}");
            }
        }
    }

    class Catalogue
    {
        public Catalogue(string typeOfVehicle, string model, string color, double horsepower)
        {
            this.TypeOfVehicle = typeOfVehicle;
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }

        public string TypeOfVehicle { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public double Horsepower { get; set; }

    }
}
