using System;
using System.Collections.Generic;

namespace SpeedRacing
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
                listCars.Add(new Car(input[0], double.Parse(input[1]),double.Parse(input[2])));
            }

            string[] command = Console.ReadLine().Split();
            while (command[0] != "End")
            {
                if (command[0] == "Drive")
                {
                    string modelToDrive = command[1];
                    double kmToDrive = double.Parse(command[2]);
                    for (int i = 0; i < listCars.Count; i++)
                    {
                        if (listCars[i].Model == modelToDrive)
                        {
                            listCars[i].Drive(kmToDrive);
                        }
                    }
                }
                command = Console.ReadLine().Split();
            }

            foreach (var car in listCars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TraveledDistance}");
            }
        }
    }

    class Car
    {
        public Car(string model, double fuelAmount, double fuelConsumptionPerKm)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
            TraveledDistance = 0;
        }
        public string Model;
        public double FuelAmount;
        public double FuelConsumptionPerKm;
        public double TraveledDistance;

        internal void Drive(double kmToDrive)
        {
            double neededFuel = FuelConsumptionPerKm * kmToDrive;
            if (FuelAmount >= neededFuel)
            {
                FuelAmount -= neededFuel;
                TraveledDistance += kmToDrive;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
