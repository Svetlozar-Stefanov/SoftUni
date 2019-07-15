using System;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double summerFuelConsumption = 1.6;

        public Truck(double fuelQuantity, double fuelConsumptionInLitersPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionInLitersPerKm + summerFuelConsumption, tankCapacity)
        {
        }

        public override void Refuel(double liters)
        {
            if (liters > 0 && FuelQuantity + liters * 0.95 <= tankCapacity)
            {
                FuelQuantity += liters * 0.95;
            }
            else if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            else if (FuelQuantity + liters * 0.95 > tankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {liters} fuel in the tank");
            }
        }
    }
}
