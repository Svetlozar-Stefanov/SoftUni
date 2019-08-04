using CarManager;
using NUnit.Framework;
using System;

namespace Tests
{
    public class CarTests
    {
        private Car car;

        [SetUp]
        public void Setup()
        {
            car = new Car("Toyota", "Astra", 2.5, 50);
        }

        [Test]
        public void ConstructorShouldInitializeValues()
        {
            Car newCar = new Car("Toyota", "Astra", 2.5, 50);

            string expectedMake = "Toyota";
            string expectedModel = "Astra";
            double expectedFuelConsumption = 2.5;
            double expectedFuelCapacity = 50;
            double expectedFuelAmount = 0;

            string actualMake = newCar.Make;
            string actualModel = newCar.Model;
            double actualFuelConsumption = newCar.FuelConsumption;
            double actualFuelCapacity = newCar.FuelCapacity;
            double actualFuelAmount = newCar.FuelAmount;

            Assert.AreEqual(expectedMake, actualMake);
            Assert.AreEqual(expectedModel, actualModel);
            Assert.AreEqual(expectedFuelConsumption, actualFuelConsumption);
            Assert.AreEqual(expectedFuelCapacity, actualFuelCapacity);
            Assert.AreEqual(expectedFuelAmount, actualFuelAmount);
        }

        

        [Test]
        public void ShouldntInitializeInvalidMake()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("", "Astra", 2.5, 50);
            }, "Make shouldnt be null or empty");
        }

        [Test]
        public void ShouldntInitializeInvalidModel()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("Toyota", "", 2.5, 50);
            }, "Model shouldnt be null or empty");
        }

        [Test]
        public void ShouldntInitializeZeroFuelConsumption()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("Toyota", "Astra", 0, 50);
            }, "Model shouldnt be zero");
        }

        [Test]
        public void ShouldntInitializeNegativeFuelConsumption()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("Toyota", "Astra", -1, 50);
            }, "Model shouldnt be negative");
        }

        [Test]
        public void ShouldntInitializeZeroFuelCapacity()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("Toyota", "Astra", 2.5, 0);
            }, "Model shouldnt be zero");
        }

        [Test]
        public void ShouldntInitializeNegativeFuelCapacity()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Car car = new Car("Toyota", "Astra", 2.5, -1);
            }, "Model shouldnt be zero");
        }

        [Test]
        public void RefuelShouldntAddNegativeFuel()
        {
            Assert.That(() => car.Refuel(-5), Throws.ArgumentException, "Fuel shouldn`t be negative");
        }

        [Test]
        public void RefuelShouldntAddZeroFuel()
        {
            Assert.That(() => car.Refuel(0), Throws.ArgumentException, "Fuel shouldn`t be negative");
        }

        [Test]
        public void RefuelShouldAddGivenFuel()
        {
            double expectedResult = 25;

            car.Refuel(25);

            double actualResult = car.FuelAmount;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void RefuelShouldNotExceedCapacity()
        {
            double expectedResult = car.FuelCapacity;

            car.Refuel(100);

            double actualResult = car.FuelAmount;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void DriveShouldntDriveIfNotEnoughFuel()
        {
            car.Refuel(50);
            Assert.That(() => car.Drive(2001), Throws.InvalidOperationException, "Cannot drive if fuel isnt enough");
        }

        [Test]
        public void DriveShouldTakeOutFuel()
        {
            car.Refuel(50);

            double expectedReult = 0;

            car.Drive(2000);

            double actualResult = car.FuelAmount;

            Assert.AreEqual(expectedReult, actualResult);
        }
    }
}