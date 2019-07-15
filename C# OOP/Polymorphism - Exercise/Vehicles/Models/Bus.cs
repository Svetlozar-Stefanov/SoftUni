namespace Vehicles.Models
{
    public class Bus : Vehicle
    {
        private const double summerCosnsumtion = 1.4;

        public Bus(double fuelQuantity, double fuelConsumptionInLitersPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionInLitersPerKm, tankCapacity)
        {
        }

        public string DriveEmpty(double km)
        {
            return base.Drive(km);
        }

        public override string Drive(double km)
        {
            if (FuelQuantity - (FuelConsumptionInLitersPerKm + summerCosnsumtion) * km > 0)
            {
                FuelQuantity -= (FuelConsumptionInLitersPerKm + summerCosnsumtion) * km;
                return $"{this.GetType().Name} travelled {km} km";
            }
            return $"{this.GetType().Name} needs refueling";
        }
    }
}
