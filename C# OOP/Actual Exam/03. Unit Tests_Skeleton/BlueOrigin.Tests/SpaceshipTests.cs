namespace BlueOrigin.Tests
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class SpaceshipTests
    {
        private const string testName = "Apollo 11";
        private const int testCapacity = 2;

        private Spaceship spaceship;

        [SetUp]
        public void SetUp()
        {
            spaceship = new Spaceship(testName, testCapacity);
        }

        [Test]
        public void ConstructorShouldInitializeCorrectly()
        {
            Spaceship spaceship = new Spaceship(testName, testCapacity);

            Assert.AreEqual(testName, spaceship.Name);
            Assert.AreEqual(testCapacity, spaceship.Capacity);
            Assert.AreEqual(0, spaceship.Count);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void NameCannotBeNullOrEmpty(string name)
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Spaceship spaceship = new Spaceship(name, testCapacity);
            });
        }

        [Test]
        public void CapacityCannotBeNegative()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Spaceship spaceship = new Spaceship(testName, -1);
            });
        }

        [Test]
        public void AddShouldAddCorrectly ()
        {
            spaceship.Add(new Astronaut("", 20));
            spaceship.Add(new Astronaut("ADC", 45));


            Assert.AreEqual(2, spaceship.Count);

        }

        [Test]
        public void CannotAddAstronautsOverTheCapacity()
        {
            spaceship.Add(new Astronaut("", 20));
            spaceship.Add(new Astronaut("ADC", 45));


            Assert.Throws<InvalidOperationException>(() =>
            {
                spaceship.Add(new Astronaut("    ", 1000));
            });
        }

        [Test]
        public void CannotAddAstronautsWhenAlreadyExisting()
        {
            Astronaut astronaut = new Astronaut("ADC", 45);

            spaceship.Add(astronaut);

            Assert.Throws<InvalidOperationException>(() =>
            {
                spaceship.Add(astronaut);
            });
        }

        [Test]
        public void RemovesCorrectly()
        {
            Astronaut astronaut = new Astronaut("ADC", 45);

            spaceship.Add(astronaut);

            Assert.AreEqual(true, spaceship.Remove(astronaut.Name));
            Assert.AreEqual(0, spaceship.Count);
        }

        [Test]
        public void CannotRemoveNonExistantAstronaut()
        {
            Astronaut astronaut = new Astronaut("ADC", 45);

            Assert.AreEqual(false, spaceship.Remove(astronaut.Name));
        }
    }
}