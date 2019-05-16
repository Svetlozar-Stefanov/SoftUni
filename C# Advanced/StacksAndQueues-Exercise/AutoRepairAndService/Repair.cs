using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoRepairAndService
{
    class Repair
    {
        static void Main(string[] args)
        {
            string[] cars = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Queue<string> carsToService = new Queue<string>(cars);
            Stack<string> servedCars = new Stack<string>();

            string[] command = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);
            while (command[0].ToLower() != "end")
            {
                string action = command[0].ToLower();
                if (carsToService.Count > 0 && action == "service")
                {
                    string currentCar = carsToService.Dequeue();
                    Console.WriteLine($"Vehicle {currentCar} got served.");
                    servedCars.Push(currentCar);
                }
                else if (action == "carinfo")
                {
                    string currentCar = command[1];
                    if (servedCars.Contains(currentCar))
                    {
                        Console.WriteLine("Served.");
                    }
                    else if (!servedCars.Contains(currentCar))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                }
                else if (action == "history")
                {
                    if (servedCars.Count > 0)
                    {
                        Console.WriteLine(String.Join(", ", servedCars));
                    }
                }

                command = Console.ReadLine()
                    .Split("-", StringSplitOptions.RemoveEmptyEntries);
            }
            if (carsToService.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {String.Join(", ", carsToService)}");
            }
            Console.WriteLine($"Served vehicles: {String.Join(", ", servedCars)}");
        }
    }
}
