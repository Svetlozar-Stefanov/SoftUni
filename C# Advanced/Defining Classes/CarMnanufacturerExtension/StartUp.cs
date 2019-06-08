namespace CarMnanufacturerExtension
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<List<Tire>> tires = new List<List<Tire>>();

            string input = Console.ReadLine();

            while (input.ToLower() != "no more tires")
            {
                string[] info = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                List<Tire> pair = new List<Tire>();
                for (int i = 0; i <= info.Length - 1; i+=2)
                {
                    pair.Add(new Tire(int.Parse(info[i]), double.Parse(info[i + 1])));
                }
                tires.Add(pair);
                input = Console.ReadLine();
            }

            List<Engine> engines = new List<Engine>();
            input = Console.ReadLine();
            while (input.ToLower() != "engines done")
            {
                string[] info = input
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);
                engines.Add(new Engine(int.Parse(info[0]), double.Parse(info[1])));

                input = Console.ReadLine();
            }

            List<Car> cars = new List<Car>();
            input = Console.ReadLine();

            while (input.ToLower() != "show special")
            {
                string[] info = input
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string make = info[0];
                string model = info[1];
                int year = int.Parse(info[2]);
                double fuelQuantity = double.Parse(info[3]);
                double fuelConsumption = double.Parse(info[4]);
                int engineIndex = int.Parse(info[5]);
                int tireIndex = int.Parse(info[6]);

                cars.Add(new Car(make, model, year, fuelQuantity, fuelConsumption, engines[engineIndex], tires[tireIndex]));
                input = Console.ReadLine();
            }

            foreach (var car in cars.Where(x => x.Year >= 2017 
            && x.Engine.HorsePower > 330 
            && x.Tires.Sum(y => y.Pressure) >= 9 
            && x.Tires.Sum(y => y.Pressure) <= 10))
            {
                car.Drive(20);
                Console.Write(car.WhoAmI());
            }
        }
    }


    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public List<Tire> Tires { get; set; }

        public Car(string make, string model, int year, double fuelQuantitiy, double fuelConsumption, Engine engine, List<Tire> tires)
        {
            Make = make;
            Model = model;
            Year = year;
            FuelQuantity = fuelQuantitiy;
            FuelConsumption = fuelConsumption;
            Engine = engine;
            Tires = tires;
        }
        public void Drive(double distance)
        {
            bool canContinue = FuelQuantity - ((distance / 100) * FuelConsumption) > 0;
            if (canContinue)
            {
                FuelQuantity -= ((distance / 100) * FuelConsumption);
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
                
            }
        }

        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Year: {Year}");
            sb.AppendLine($"HorsePowers: {Engine.HorsePower}");
            sb.AppendLine($"FuelQuantity: {FuelQuantity}");
            return sb.ToString();
        }
    }
    public class Engine
    {
        public int HorsePower { get; set; }
        public double CubicCapacity { get; set; }

        public Engine(int horsePower, double cubicCapacity)
        {
            HorsePower = horsePower;
            CubicCapacity = cubicCapacity;
        }
    }

    public class Tire
    {
        public int Year { get; set; }
        public double Pressure { get; set; }

        public Tire(int year, double pressure)
        {
            Year = year;
            Pressure = pressure;
        }
    }
}
