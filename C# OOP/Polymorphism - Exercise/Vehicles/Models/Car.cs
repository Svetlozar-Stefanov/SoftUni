namespace Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double summerFuelConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumptionInLitersPerKm, double tankCapacity) 
            : base(fuelQuantity, fuelConsumptionInLitersPerKm + summerFuelConsumption, tankCapacity)
        {
        }
    }
}
