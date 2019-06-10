using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData.Classes
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input.Length == 13)
                {
                    string model = input[0];
                    int engineSpeed = int.Parse(input[1]);
                    int enginePower = int.Parse(input[2]);
                    Engine newEngine = new Engine(engineSpeed, enginePower);
                    int cargoWeight = int.Parse(input[3]);
                    string cargoType = input[4];
                    Cargo newCargo = new Cargo(cargoWeight, cargoType);
                    List<Tire> newTires = new List<Tire>();
                    for (int j = 5; j < input.Length-1; j+=2)
                    {
                        double tirePressure = double.Parse(input[j]);
                        int tireAge = int.Parse(input[j+1]);

                        Tire newTire = new Tire(tirePressure, tireAge);
                        newTires.Add(newTire);
                    }

                    Car newCar = new Car(model, newEngine, newCargo, newTires);
                    cars.Add(newCar);
                }
            }

            string show = Console.ReadLine();
            if (show == "fragile")
            {
                foreach (var car in cars.Where(x => x.Cargo.CargoType == "fragile"))
                {
                    if (car.Tires.Any(x =>x.TirePressure < 1))
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            if (show == "flamable")
            {
                foreach (var car in cars.Where(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
