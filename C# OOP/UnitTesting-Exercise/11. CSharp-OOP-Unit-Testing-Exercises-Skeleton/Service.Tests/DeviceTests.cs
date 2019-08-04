using NUnit.Framework;
using Service.Models.Contracts;
using Service.Models.Devices;
using Service.Models.Parts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Service.Tests
{
    public class DeviceTests
    {
        private const string testMake = "Ustroistvo";

        [Test]
        public void ConstructorsShouldInitializeCorrectly()
        {
            string expectedMake = testMake;

            Laptop laptop = new Laptop(testMake);
            PC PC = new PC(testMake);
            Phone phone = new Phone(testMake);

            Assert.AreEqual(expectedMake, laptop.Make);
            Assert.That(laptop.Parts, Is.Not.Null);

            Assert.AreEqual(expectedMake, PC.Make);
            Assert.That(PC.Parts, Is.Not.Null);

            Assert.AreEqual(expectedMake, phone.Make);
            Assert.That(phone.Parts, Is.Not.Null);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void MakeValidation(string make)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Laptop laptop = new Laptop(make);
            });
        }

        [Test]
        public void PartsReturnCorrect()
        {
            var laptopPart = new LaptopPart("Any", 20);
            var laptopPart2 = new LaptopPart("One", 20);

            Laptop laptop = new Laptop(testMake);
            laptop.AddPart(laptopPart);
            laptop.AddPart(laptopPart2);
            var laptopParts = laptop.Parts;
            Assert.That(laptopParts, Has.Member(laptopPart));
            Assert.That(laptopParts, Has.Member(laptopPart2));

            Assert.AreEqual(2, laptopParts.Count);
            var test = new List<IPart>();
            Type testType = test.GetType();
            Type typePhoneParts = laptopParts.GetType();
            Assert.AreEqual(testType, typePhoneParts);
        }

        [Test]
        public void AddPartValidation()
        {
            Laptop laptop = new Laptop(testMake);
            Assert.Throws<InvalidOperationException>(() => 
            {
                laptop.AddPart(new PCPart("any", 12, false));
            });

            PC pc = new PC(testMake);
            Assert.Throws<InvalidOperationException>(() =>
            {
                pc.AddPart(new PhonePart("any", 12, false));
            });

            Phone phone = new Phone(testMake);
            Assert.Throws<InvalidOperationException>(() =>
            {
                phone.AddPart(new PCPart("any", 12, false));
            });
        }

        [Test]
        public void AddShouldntAddExistingPart()
        { 
            Laptop laptop = new Laptop(testMake);
            PC pc = new PC(testMake);
            Phone phone = new Phone(testMake);

            laptop.AddPart(new LaptopPart("any", 12, false));
            pc.AddPart(new PCPart("any", 12, false));
            phone.AddPart(new PhonePart("any", 12, false));

            Assert.Throws<InvalidOperationException>(() =>
            {
                laptop.AddPart(new LaptopPart("any", 12, false));
            });

            Assert.Throws<InvalidOperationException>(() =>
            {
                pc.AddPart(new PCPart("any", 12, false));
            });

            Assert.Throws<InvalidOperationException>(() =>
            {
                phone.AddPart(new PhonePart("any", 12, false));
            });
        }

        [Test]
        public void AddShouldAddNewPart()
        {
            int expectedCount = 1;

            Laptop laptop = new Laptop(testMake);
            PC pc = new PC(testMake);
            Phone phone = new Phone(testMake);

            laptop.AddPart(new LaptopPart("any", 12, false));
            pc.AddPart(new PCPart("any", 12, false));
            phone.AddPart(new PhonePart("any", 12, false));

            var laptopParts = laptop.Parts;
            var pcParts = pc.Parts;
            var phoneParts = pc.Parts;

            Assert.AreEqual(expectedCount, laptopParts.Count);
            Assert.AreEqual(expectedCount, pcParts.Count);
            Assert.AreEqual(expectedCount, phoneParts.Count);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void RemovePartValidation(string partName)
        {
            Laptop laptop = new Laptop(testMake);
            Assert.Throws<ArgumentException>(() =>
            {
                laptop.RemovePart(partName);
            });
        }

        [Test]
        [TestCase("None")]
        public void RemovePartNoPartValidation(string partName)
        {
            Laptop laptop = new Laptop(testMake);
            Assert.Throws<InvalidOperationException>(() =>
            {
                laptop.RemovePart(partName);
            });
        }

        [Test]
        public void RemoveShouldRemoveCorrectly()
        {
            string partName = "Any";
            int expectedResult = 0;

            Laptop laptop = new Laptop(testMake);

            laptop.AddPart(new LaptopPart("Any", 20));

            laptop.RemovePart(partName);

            Assert.AreEqual(expectedResult, laptop.Parts.Count);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void RepairPartCannotAcceptNullOrEmpty(string part)
        {
            Laptop laptop = new Laptop(testMake);

            Assert.Throws<ArgumentException>(() =>
            {
                laptop.RepairPart(part);
            });
        }

        [Test]
        public void RepairCannotWorkOnNonExistantParts()
        {
            Laptop laptop = new Laptop(testMake);
            Assert.Throws<InvalidOperationException>(() =>
            {
                laptop.RepairPart("None");
            });
        }

        [Test]
        public void RepairCannotWorkOnNonRepairedParts()
        {
            Laptop laptop = new Laptop(testMake);
            laptop.AddPart(new LaptopPart("Any", 20));

            Assert.Throws<InvalidOperationException>(() =>
            {
                laptop.RepairPart("Any");
            });
        }

        [Test]
        public void RepairShouldActProperly()
        {
            bool expectedResult = false;

            Laptop laptop = new Laptop(testMake);

            laptop.AddPart(new LaptopPart("Part", 20, true));
            laptop.RepairPart("Part");

            Assert.AreEqual(expectedResult, laptop.Parts.First().IsBroken);
        }
    }
}
