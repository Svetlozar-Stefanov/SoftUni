using System;

namespace Vehicles.Models
{
    public abstract class Vehicle
    {
        protected double fuelQuantity;

        protected double fuelConsumptionInLitersPerKm;

        protected double tankCapacity;

        public Vehicle(double fuelQuantity, double fuelConsumptionInLitersPerKm, double tankCapacity)
        {
            TankCapacity = tankCapacity;
            if (fuelQuantity > TankCapacity)
            {
                FuelQuantity = 0;
            }
            else
            {
                FuelQuantity = fuelQuantity;
            }
            FuelConsumptionInLitersPerKm = fuelConsumptionInLitersPerKm;
        }

        public virtual double FuelQuantity
        {
            get
            {
                return fuelQuantity;
            }
            protected set
            {
                Validator.CheckValue(value);
                
                fuelQuantity = value;
            }
        }

        public virtual double FuelConsumptionInLitersPerKm
        {
            get
            {
                return fuelConsumptionInLitersPerKm;
            }
            protected set
            {
                Validator.CheckValue(value);
                fuelConsumptionInLitersPerKm = value;
            }
        }

        public virtual double TankCapacity
        {
            get
            {
                return tankCapacity;
            }
            private set
            {
                Validator.CheckValue(value);
                tankCapacity = value;
            }
        }

        public virtual string Drive(double km)
        {
            if (FuelQuantity - FuelConsumptionInLitersPerKm * km > 0)
            {
                FuelQuantity -= FuelConsumptionInLitersPerKm * km;
                return $"{this.GetType().Name} travelled {km} km";
            }
            return $"{this.GetType().Name} needs refueling";
        }

        public virtual void Refuel(double liters)
        {
            if (liters > 0 && FuelQuantity + liters <= tankCapacity)
            {
                FuelQuantity += liters;
            }
            else if (liters <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }
            else if (FuelQuantity + liters > tankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {liters} fuel in the tank");
            }
        }
    }
}
