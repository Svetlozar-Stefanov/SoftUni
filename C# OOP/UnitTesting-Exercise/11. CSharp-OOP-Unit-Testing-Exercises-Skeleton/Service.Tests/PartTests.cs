using NUnit.Framework;
using Service.Models.Parts;
using System;

namespace Tests
{
    public class PartTests
    {
        private const decimal pcMultiplier = 1.2m;
        private const decimal phoneMultiplier = 1.3m;
        private const decimal laptopMultiplier = 1.5m;

        private string testName = "Chark";
        private decimal testCost = 20;
        private bool testIsBroken = true;

        [Test]
        public void DefaultConstructorsShouldInitializeCorrectly()
        {
            string expectedName = testName;
            decimal expectedCost = testCost;
            bool expectedIsBroken = false;

            LaptopPart laptopPart = new LaptopPart(testName, testCost);
            PCPart pcPart = new PCPart(testName, testCost);
            PhonePart phonePart = new PhonePart(testName, testCost);

            Assert.AreEqual(expectedName, laptopPart.Name);
            Assert.AreEqual(expectedCost * laptopMultiplier, laptopPart.Cost);
            Assert.AreEqual(expectedIsBroken, laptopPart.IsBroken);

            Assert.AreEqual(expectedName, pcPart.Name);
            Assert.AreEqual(expectedCost * pcMultiplier, pcPart.Cost);
            Assert.AreEqual(expectedIsBroken, pcPart.IsBroken);

            Assert.AreEqual(expectedName, phonePart.Name);
            Assert.AreEqual(expectedCost * phoneMultiplier, phonePart.Cost);
            Assert.AreEqual(expectedIsBroken, phonePart.IsBroken);
        }

        [Test]
        public void ConstructorsShouldInitializeCorrectly()
        {
            string expectedName = testName;
            decimal expectedCost = testCost;
            bool expectedIsBroken = true;

            LaptopPart laptopPart = new LaptopPart(testName, testCost, testIsBroken);
            PCPart pcPart = new PCPart(testName, testCost, testIsBroken);
            PhonePart phonePart = new PhonePart(testName, testCost, testIsBroken);

            Assert.AreEqual(expectedName, laptopPart.Name);
            Assert.AreEqual(expectedCost * laptopMultiplier, laptopPart.Cost);
            Assert.AreEqual(expectedIsBroken, laptopPart.IsBroken);

            Assert.AreEqual(expectedName, pcPart.Name);
            Assert.AreEqual(expectedCost * pcMultiplier, pcPart.Cost);
            Assert.AreEqual(expectedIsBroken, pcPart.IsBroken);

            Assert.AreEqual(expectedName, phonePart.Name);
            Assert.AreEqual(expectedCost * phoneMultiplier, phonePart.Cost);
            Assert.AreEqual(expectedIsBroken, phonePart.IsBroken);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void NameCannotBeNullOrEmpty(string name)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                LaptopPart laptopPart = new LaptopPart(name, testCost);
            });
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void PriceCannotBeZeroOrNegative(decimal cost)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                LaptopPart laptopPart = new LaptopPart(testName, cost);
            });
        }

        [Test]
        public void RepairShouldChangePartState()
        {
            bool expectedIsBroken = false;

            LaptopPart laptopPart = new LaptopPart(testName, testCost, testIsBroken);

            laptopPart.Repair();

            Assert.AreEqual(expectedIsBroken, laptopPart.IsBroken);
        }

        [Test]
        public void ReportShouldReturnCorrectInfo()
        {
            string expectedLaptopResult = $"{testName} - {testCost * laptopMultiplier:f2}$" + Environment.NewLine +
                $"Broken: {testIsBroken}";

            LaptopPart laptopPart = new LaptopPart(testName, testCost, testIsBroken);

            Assert.AreEqual(expectedLaptopResult, laptopPart.Report());
        }
    }
}