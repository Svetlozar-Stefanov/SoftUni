using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    public class Parking
    {
        private int capacity;
        private List<Car> cars;
        public Parking(int capacity)
        {
            this.capacity = capacity;
            cars = new List<Car>();
        }

        public string AddCar(Car car)
        {
            if (cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            if (capacity <= cars.Count)
            {
                return "Parking is full!";
            }
            cars.Add(car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string registrationNumber)
        {
            Car car = cars.Where(c => c.RegistrationNumber == registrationNumber)
                .FirstOrDefault();

            if (car == null)
            {
                return "Car with that registration number, doesn't exist!";
            }
            cars.Remove(car);
            return $"Successfully removed {registrationNumber}";
        }

        public Car GetCar(string registrationNumber)
        {
            if (cars.Any(c => c.RegistrationNumber == registrationNumber))
            {
                return cars.Where(c => c.RegistrationNumber == registrationNumber)
                .FirstOrDefault();
            }
            return null;
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var reagisterNumber in registrationNumbers)
            {
                cars.RemoveAll(c => c.RegistrationNumber == reagisterNumber);
            }
        }

        public int Count
        {
            get
            {
                return cars.Count;
            }
            set
            {
                Count = value;
            }
        }

    }
}
