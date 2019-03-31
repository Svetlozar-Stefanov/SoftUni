using System;
using System.Collections.Generic;
using System.Linq;

namespace VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            Catalogue catalogue = new Catalogue();
            while (true)
            {
                string[] command = Console.ReadLine().Split('/');
                if (command[0] == "end")
                {
                    break;
                }

                string type = command[0];
                string brand = command[1];
                string model = command[2];
                int properties = int.Parse(command[3]);

                if (type.ToLower() == "car")
                {
                    Car newCar = new Car();
                    newCar.Brand = brand;
                    newCar.Model = model;
                    newCar.HorsePower = properties;
                    catalogue.cars.Add(newCar);
                }
                else if (type.ToLower() == "truck")
                {
                    Truck newTruck = new Truck();
                    newTruck.Brand = brand;
                    newTruck.Model = model;
                    newTruck.Weight = properties;
                    catalogue.trucks.Add(newTruck);
                }
            }
            if (catalogue.cars.Count > 0)
            {
                List<Car> finalCars = catalogue.cars.OrderBy(x => x.Brand).ToList();
                Console.WriteLine("Cars:");
                foreach (var car in finalCars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalogue.trucks.Count > 0)
            {
                List<Truck> finalTrucks = catalogue.trucks.OrderBy(x => x.Brand).ToList();
                Console.WriteLine("Trucks:");
                foreach (var truck in finalTrucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }

    class Truck
    {
        public string Brand;
        public string Model;
        public int Weight;
    }

    class Car
    {
        public string Brand;
        public string Model;
        public int HorsePower;
    }

    class Catalogue
    {
        public Catalogue()
        {
            cars = new List<Car>();
            trucks = new List<Truck>();
        }
        public List<Car> cars = new List<Car>();
        public List<Truck> trucks = new List<Truck>();
    }
}
