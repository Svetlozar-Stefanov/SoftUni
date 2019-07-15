using System;
using System.Collections.Generic;
using Vehicles.Models;

namespace Vehicles
{
    public class Engine
    {
        public Engine()
        {

        }

        private Car car = null;

        private Truck truck = null;

        private Bus bus = null;

        public void RunFirstTask()
        {
            ReadInput();

            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                ExecuteCommands();
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.Write($"Bus: {bus.FuelQuantity:f2}".TrimEnd());
        }

        private void ExecuteCommands()
        {
            string[] info = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);
            try
            {
                if (info[0].ToLower() == "drive" && info[1].ToLower() == "car")
                {
                    double km = double.Parse(info[2]);

                    Console.WriteLine(car.Drive(km));
                }
                else if (info[0].ToLower() == "drive" && info[1].ToLower() == "truck")
                {
                    double km = double.Parse(info[2]);

                    Console.WriteLine(truck.Drive(km));
                }
                else if (info[0].ToLower() == "drive" && info[1].ToLower() == "bus")
                {
                    double km = double.Parse(info[2]);

                    Console.WriteLine(bus.Drive(km));
                }
                else if (info[0].ToLower() == "driveempty" && info[1].ToLower() == "bus")
                {
                    double km = double.Parse(info[2]);

                    Console.WriteLine(bus.DriveEmpty(km));
                }
                else if (info[0].ToLower() == "refuel" && info[1].ToLower() == "car")
                {
                    double liters = double.Parse(info[2]);

                    car.Refuel(liters);
                }
                else if (info[0].ToLower() == "refuel" && info[1].ToLower() == "truck")
                {
                    double liters = double.Parse(info[2]);

                    truck.Refuel(liters);
                }
                else if (info[0].ToLower() == "refuel" && info[1].ToLower() == "bus")
                {
                    double liters = double.Parse(info[2]);

                    bus.Refuel(liters);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        private void ReadInput()
        {
            for (int i = 1; i <= 3; i++)
            {
                string[] input = Console.ReadLine()
                           .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                double fuelQuantity = double.Parse(input[1]);
                double fuelConsumption = double.Parse(input[2]);
                double tankCapacity = double.Parse(input[3]);

                if (i == 1)
                {
                    car = new Car(fuelQuantity, fuelConsumption, tankCapacity);
                }
                if (i == 2)
                {
                    truck = new Truck(fuelQuantity, fuelConsumption, tankCapacity);
                }
                if (i == 3)
                {
                    bus = new Bus(fuelQuantity, fuelConsumption, tankCapacity);
                }
            }
        }
    }
}
