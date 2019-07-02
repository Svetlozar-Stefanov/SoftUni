using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_RawData
{
    
    class RawData
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] parameters = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = parameters[0]; 
                int engineSpeed = int.Parse(parameters[1]);
                int enginePower = int.Parse(parameters[2]);

                int cargoWeight = int.Parse(parameters[3]);
                string cargoType = parameters[4];
                Cargo cargo = new Cargo(cargoWeight, cargoType);

                Car car = new Car(model, engineSpeed, enginePower, cargo);

                for (int j = 5; j < parameters.Length - 1; j+=2)
                {
                    Tire tire = new Tire(double.Parse(parameters[j]), int.Parse(parameters[j + 1]));
                    car.Tires.Add(tire);
                }
                cars.Add(car);
            }

            string command = Console.ReadLine();
            if (command == "fragile")
            {
                List<string> fragile = cars
                    .Where(c => c.Cargo.Type == "fragile" && c.Tires.Any(y => y.Pressure < 1))
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, fragile));
            }
            else
            {
                List<string> flamable = cars
                    .Where(c => c.Cargo.Type == "flamable" && c.EnginePower > 250)
                    .Select(x => x.Model)
                    .ToList();

                Console.WriteLine(string.Join(Environment.NewLine, flamable));
            }
        }
    }
}
