namespace INStock.Tests
{
    using INStock.Contracts;
    using INStock.Models;
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class ProductStockTests
    {
        private const string testLabel = "Some";
        private const decimal testPrice = 20.99m;
        private const int testQuantity = 5;

        private IProductStock productStock;

        [SetUp]
        public void SetUp()
        {
            productStock = new ProductStock();
        }

        [Test]
        public void ConstructorShouldInitializeCorrectly()
        {
            ProductStock products = new ProductStock();

            Assert.AreEqual(0, products.Count);
        }

        [Test]
        public void AddShouldAddCorrectly()
        {
            int expectedCount = 1;

            productStock.Add(new Product(testLabel, testPrice, testQuantity));

            Assert.AreEqual(expectedCount, productStock.Count);
        }

        [Test]
        public void CannotAddExistingProductWithDifferentPrice()
        {
            Product product = new Product(testLabel, testPrice, testQuantity);
            Product testProduct = new Product(testLabel, testPrice + 10, testQuantity);

            productStock.Add(product);

            Assert.Throws<InvalidOperationException>(() =>
            {
                productStock.Add(testProduct);
            });
        }

        [Test]
        public void AddShouldAddExistingValidProductsQuantity()
        {
            Product product = new Product(testLabel, testPrice, testQuantity);
            Product testProduct = new Product(testLabel, testPrice, testQuantity);

            productStock.Add(product);
            productStock.Add(testProduct);

            Assert.AreEqual(10, productStock.FirstOrDefault(p => p.Label == testLabel).Quantity);
        }

        [Test]
        public void AddCannotAddNull()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                productStock.Add(null);
            });
        }

        [Test]
        public void ContainsShouldFindProduct()
        {
            Product product = new Product(testLabel, testPrice, testQuantity);

            productStock.Add(product);

            Assert.That(productStock.Contains(product));
        }

        [Test]
        public void ContainsCannotAcceptNull()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                productStock.Contains(null);
            });
        }

        [Test]
        public void FindShouldReturnCorrectProduct()
        {
            IProduct product1 = new Product("Banani", testPrice, testQuantity);
            IProduct product2 = new Product("Chireshi", testPrice, testQuantity);
            IProduct product3 = new Product("Smukini", testPrice, testQuantity);

            productStock.Add(product1);
            productStock.Add(product2);
            productStock.Add(product3);

            int index = 2;

            IProduct resultProduct = productStock.Find(index);

            Assert.AreEqual(product2, resultProduct);

        }

        [Test]
        [TestCase(-1)]
        [TestCase(10)]
        public void FindCannotAcceptOutOfRangeIndexes(int index)
        {
            IProduct product1 = new Product("Banani", testPrice, testQuantity);
            IProduct product2 = new Product("Chireshi", testPrice, testQuantity);
            IProduct product3 = new Product("Smukini", testPrice, testQuantity);

            productStock.Add(product1);
            productStock.Add(product2);
            productStock.Add(product3);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                productStock.Find(index);
            });
        }

        [Test]
        public void FindByLabelShouldReturnCorrectProduct()
        {
            IProduct product1 = new Product("Banani", testPrice, testQuantity);
            IProduct product2 = new Product("Chireshi", testPrice, testQuantity);
            IProduct product3 = new Product("Smukini", testPrice, testQuantity);

            productStock.Add(product1);
            productStock.Add(product2);
            productStock.Add(product3);

            IProduct resultProduct = productStock.FindByLabel("Chireshi");

            Assert.AreEqual(product2, resultProduct);

        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void FindByLabelCannotAcceptNullOrEmpty(string label)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                productStock.FindByLabel(label);
            });
        }

        [Test]
        public void FindAllInPriceRangeShouldBeCorrect()
        {
            IProduct product1 = new Product("Banani", 10, testQuantity);
            IProduct product2 = new Product("Chireshi", 4, testQuantity);
            IProduct product3 = new Product("Smukini", 6, testQuantity);

            productStock.Add(product1);
            productStock.Add(product2);
            productStock.Add(product3);

            var productsInRange = productStock.FindAllInRange(3m, 8m);

            Assert.That(productsInRange.Contains(product2));
            Assert.That(productsInRange.Contains(product3));
        }

        [Test]
        [TestCase(-1, 20)]
        [TestCase(20, -1)]
        [TestCase(-1, -1)]
        public void FindAllInRangeCannotAcceptZeroNegative(decimal loPrice, decimal hiPrice)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                productStock.FindAllInRange(loPrice,hiPrice);
            });
        }

        [Test]
        public void FindByPriceShouldReturnCorrectProduct()
        {
            IProduct product1 = new Product("Banani", 5, testQuantity);
            IProduct product2 = new Product("Chireshi", 20, testQuantity);
            IProduct product3 = new Product("Smukini", 20, testQuantity);

            productStock.Add(product1);
            productStock.Add(product2);
            productStock.Add(product3);

            var resultProducts = productStock.FindAllByPrice(20);

            Assert.That(resultProducts.Contains(product2));
            Assert.That(resultProducts.Contains(product3));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void FindByPriceCannotAcceptZeroOrNegative(decimal price)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                productStock.FindAllByPrice(price);
            });
        }

        [Test]
        public void FindMostExpensiveProduct()
        {
            IProduct product1 = new Product("Banani", 1, testQuantity);
            IProduct product2 = new Product("Chireshi", 30, testQuantity);
            IProduct product3 = new Product("Smukini", 10, testQuantity);

            productStock.Add(product1);
            productStock.Add(product2);
            productStock.Add(product3);

            var resultProduct = productStock.FindMostExpensiveProduct();

            Assert.AreEqual(resultProduct, product2);
        }

        [Test]
        public void FindByQuantityShouldReturnCorrectProduct()
        {
            IProduct product1 = new Product("Banani", testPrice, 2);
            IProduct product2 = new Product("Chireshi", testPrice, 2);
            IProduct product3 = new Product("Smukini", testPrice, 40);

            productStock.Add(product1);
            productStock.Add(product2);
            productStock.Add(product3);

            var resultProducts = productStock.FindAllByQuantity(2);

            Assert.That(resultProducts.Contains(product1));
            Assert.That(resultProducts.Contains(product2));
        }

        [Test]
        [TestCase(-1)]
        public void FindByQuantityCannotAcceptZeroOrNegative(int quantity)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                productStock.FindAllByPrice(quantity);
            });
        }

        [Test]
        public void IndexerShouldReturnCorrectProduct()
        {
            IProduct product1 = new Product("Banani", testPrice, testQuantity);
            IProduct product2 = new Product("Chireshi", testPrice, testQuantity);
            IProduct product3 = new Product("Smukini", testPrice, testQuantity);

            productStock.Add(product1);
            productStock.Add(product2);
            productStock.Add(product3);

            int index = 1;

            IProduct resultProduct = productStock[index];

            Assert.AreEqual(product2, resultProduct);

        }

        [Test]
        [TestCase(-1)]
        [TestCase(10)]
        public void IndexerCannotAcceptOutOfRangeIndexes(int index)
        {
            IProduct product1 = new Product("Banani", testPrice, testQuantity);
            IProduct product2 = new Product("Chireshi", testPrice, testQuantity);
            IProduct product3 = new Product("Smukini", testPrice, testQuantity);

            productStock.Add(product1);
            productStock.Add(product2);
            productStock.Add(product3);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                var result = productStock[index];
            });
        }
    }

}
