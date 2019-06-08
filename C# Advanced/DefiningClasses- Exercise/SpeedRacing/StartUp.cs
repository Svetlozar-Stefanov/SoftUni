using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int numberOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] info = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = info[0];
                double fuel = double.Parse(info[1]);
                double consumption = double.Parse(info[2]);

                cars.Add(new Car(model, fuel, consumption));
            }

            string[] input = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            while (input[0].ToLower() != "end")
            {
                if (input[0].ToLower() == "drive")
                {
                    string carModel = input[1];
                    double distance = double.Parse(input[2]);

                    Car searchedCar = cars.Where(x => x.Model == carModel).FirstOrDefault();
                    cars[cars.IndexOf(searchedCar)].Drive(distance);
                }

                input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
