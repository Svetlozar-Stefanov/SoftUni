namespace INStock.Tests
{
    using INStock.Contracts;
    using INStock.Models;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ProductTests
    {
        private const string testLabel = "Some";
        private const decimal testPrice = 20.99m;
        private const int testQuantity = 5;

        [Test]
        public void ConstructorInitializesCorrectly()
        {
            IProduct product = new Product(testLabel, testPrice, testQuantity);

            Assert.AreEqual(testLabel, product.Label);
            Assert.AreEqual(testPrice, product.Price);
            Assert.AreEqual(testQuantity, product.Quantity);
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void LabelCannotBeNullOrEmpty(string label)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                IProduct product = new Product(label, testPrice , testQuantity);
            });
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void PriceCannotBeZeroOrNegative(decimal price)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                IProduct product = new Product(testLabel, price, testQuantity);
            });
        }

        [Test]
        public void QuantityCannotBeNegative()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                IProduct product = new Product(testLabel, testPrice, -1);
            });
        }
    }
}