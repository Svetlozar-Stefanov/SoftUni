using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();

            int engineNumbers = int.Parse(Console.ReadLine());

            for (int i = 0; i < engineNumbers; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                int power = int.Parse(input[1]);

                if (input.Length < 3)
                {
                    engines.Add(new Engine(model, power));
                }
                else if (input.Length < 4)
                {
                    string addOn = input[2];
                    engines.Add(new Engine(model, power, addOn));
                }
                else
                {
                    string displacement = input[2];
                    string efficiency = input[3];
                    engines.Add(new Engine(model, power, displacement,efficiency));
                }
            }

            List<Car> cars = new List<Car>();

            int linesOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesOfCars; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                string engine = input[1];
                Engine searchedEngine = engines
                    .Where(x => x.Model.ToLower() == engine.ToLower())
                    .FirstOrDefault();

                if (input.Length < 3)
                {
                    cars.Add(new Car(model, searchedEngine));
                }
                else if (input.Length < 4)
                {
                    string addOn = input[2];
                    cars.Add(new Car(model, searchedEngine, addOn));
                }
                else
                {
                    string weight = input[2];
                    string color = input[3];
                    cars.Add(new Car(model, searchedEngine, weight, color));
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");
                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
                Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
                Console.WriteLine($"  Weight: {car.Weight}");
                Console.WriteLine($"  Color: {car.Color}");

            }
        }
    }
}
