using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedRacing
{
    public class Car
    {
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKm { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuel, double consumption)
        {
            Model = model;
            FuelAmount = fuel;
            FuelConsumptionPerKm = consumption;
            TravelledDistance = 0;
        }

        public void Drive(double distance)
        {
            double neededFuel = FuelConsumptionPerKm * distance;
            if (FuelAmount >= neededFuel)
            {
                FuelAmount -= neededFuel;
                TravelledDistance += distance;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
