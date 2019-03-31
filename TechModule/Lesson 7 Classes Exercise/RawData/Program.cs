using System;
using System.Collections.Generic;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> listCars = new List<Car>();
            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split();
                listCars.Add(new Car(input[0], int.Parse(input[1]), int.Parse(input[2]), int.Parse(input[3]), input[4]));
            }

            string searchedCargoType = Console.ReadLine();

            foreach (var car in listCars)
            {
                if (searchedCargoType == "fragile" 
                    && car.Cargo.CargoType == searchedCargoType 
                    && car.Cargo.CargoWeight < 1000)
                {
                    Console.WriteLine(car.Model);
                }
                else if (searchedCargoType == "flamable"
                    && car.Cargo.CargoType == searchedCargoType 
                    && car.Engine.EnginePower > 250)
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }

    class Car
    {
        public Car(string model, int speed, int power, int weight, string type)
        {
            Model = model;
            Engine = new Engine(speed, power);
            Cargo = new Cargo(weight, type);
        }
        public string Model;
        public Engine Engine;
        public Cargo Cargo;
    }

    class Cargo
    {
        public Cargo(int cargoWeight, string cargoType)
        {
            CargoWeight = cargoWeight;
            CargoType = cargoType;
        }
        public int CargoWeight;
        public string CargoType;
    }

    class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }
        public int EngineSpeed;
        public int EnginePower;
    }
}
