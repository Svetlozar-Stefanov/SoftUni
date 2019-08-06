namespace ParkingSystem.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class SoftParkTest
    {
        private string testMake = "Toyta";
        private string testRegistrationNumber = "A4P23";

        private SoftPark softPark;
        private Car car;

        [SetUp]
        public void Setup()
        {
            softPark = new SoftPark();
            car = new Car(testMake, testRegistrationNumber);
        }

        [Test]
        public void CarConstructorShouldInitializeCorrectly()
        {
            Car car = new Car(testMake, testRegistrationNumber);

            Assert.AreEqual(testMake, car.Make);
            Assert.AreEqual(testRegistrationNumber, car.RegistrationNumber);
        }

        [Test]
        public void ParkingConstructorShouldInitializeCorrectly()
        {
            SoftPark softPark = new SoftPark();

            Assert.That(softPark.Parking != null);
            Assert.AreEqual(12, softPark.Parking.Count);
        }

        [Test]
        public void ParkCarShouldWorkCorrectly()
        {
            string result =  softPark.ParkCar("A1", car);

            Assert.That(softPark.Parking.Values.Contains(car));
            Assert.AreEqual(result, $"Car:{car.RegistrationNumber} parked successfully!");
        }

        [Test]
        public void ParkCarCannotExecuteOnNonExistantSpace()
        {

            Assert.Throws<ArgumentException>(() =>
            {
                softPark.ParkCar("Q98", car);
            });
        }

        [Test]
        public void ParkCarCannotParkOnTakenSpot()
        {
            softPark.ParkCar("A1", car);

            Assert.Throws<ArgumentException>(() =>
            {
                softPark.ParkCar("A1", car);
            });
        }

        [Test]
        public void ParkCarCannotParkParkedCar()
        {
            softPark.ParkCar("A1", car);

            Assert.Throws<InvalidOperationException>(() =>
            {
                softPark.ParkCar("A2", car);
            });
        }

        [Test]
        public void RemoveShouldWorkCorrectly()
        {
            softPark.ParkCar("A1", car);

            string result = softPark.RemoveCar("A1", car);

            Assert.That(!softPark.Parking.Values.Contains(car));
            Assert.AreEqual(result, $"Remove car:{car.RegistrationNumber} successfully!");
        }

        [Test]
        public void CannotRemoveNonExistantSpot()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                softPark.RemoveCar("Q98", car);
            });
        }

        [Test]
        public void ParkCarCannotRemoveOnSpotWithDifferentCar()
        {
            softPark.ParkCar("A1", car);

            Assert.Throws<ArgumentException>(() =>
            {
                Car newCar = new Car("a", "a2");

                softPark.RemoveCar("A1", newCar);
            });
        }
    }
}