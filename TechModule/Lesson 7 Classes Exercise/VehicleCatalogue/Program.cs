using System;
using System.Collections.Generic;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue vehicleCatalogue = new Catalogue();
            string[] info = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries);

            double carHorsepowerSum = 0;
            int carCount = 0;
            double truckHorsepowerSum = 0;
            int truckCount = 0;
            while (info[0].ToLower() != "end")
            {
                string type = info[0];
                string model = info[1];
                string color = info[2];
                int horsepower = int.Parse(info[3]);

                if (type.ToLower() == "car")
                {
                    vehicleCatalogue.ListCars.Add(new Car(model, color, horsepower));
                    carHorsepowerSum += horsepower;
                    carCount++;
                }
                else if (type.ToLower() == "truck")
                {
                    vehicleCatalogue.ListTrucks.Add(new Truck(model, color, horsepower));
                    truckHorsepowerSum += horsepower;
                    truckCount++;
                }

                info = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }

            string desiredModel = Console.ReadLine();

            while (desiredModel.ToLower() != "close the catalogue")
            {
                for (int i = 0; i < vehicleCatalogue.ListCars.Count; i++)
                {
                    if (vehicleCatalogue.ListCars[i].Model.ToLower() == desiredModel.ToLower())
                    {
                        Console.WriteLine($"Type: Car");
                        Console.WriteLine($"Model: {vehicleCatalogue.ListCars[i].Model}");
                        Console.WriteLine($"Color: {vehicleCatalogue.ListCars[i].Color}");
                        Console.WriteLine($"Horsepower: {vehicleCatalogue.ListCars[i].Horsepower}");
                    }
                }
                for (int i = 0; i < vehicleCatalogue.ListTrucks.Count; i++)
                {
                    if (vehicleCatalogue.ListTrucks[i].Model.ToLower() == desiredModel.ToLower())
                    {
                        Console.WriteLine($"Type: Truck");
                        Console.WriteLine($"Model: {vehicleCatalogue.ListTrucks[i].Model}");
                        Console.WriteLine($"Color: {vehicleCatalogue.ListTrucks[i].Color}");
                        Console.WriteLine($"Horsepower: {vehicleCatalogue.ListTrucks[i].Horsepower}");
                    }
                }
                desiredModel = Console.ReadLine();
            }
            double avgHorsePowerCars = carHorsepowerSum / carCount;
            double avgHorsePowerTrucks = truckHorsepowerSum / truckCount;
            if (carCount == 0)
            {
                avgHorsePowerCars = 0;
            }
            if (truckCount == 0)
            {
                avgHorsePowerTrucks = 0;
            }
            Console.WriteLine($"Cars have average horsepower of: {avgHorsePowerCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avgHorsePowerTrucks:f2}.");

        }
    }

    class Catalogue
    {
        public Catalogue()
        {
            ListCars = new List<Car>();
            ListTrucks = new List<Truck>();
        }
        public List<Car> ListCars;
        public List<Truck> ListTrucks;
    }

    class Car
    {
        public Car(string model, string color, int horsepower)
        {
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }
        public string Model;
        public string Color;
        public int Horsepower;
    }
    class Truck
    {
        public Truck(string model, string color, int horsepower)
        {
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }
        public string Model;
        public string Color;
        public int Horsepower;
    }
}
