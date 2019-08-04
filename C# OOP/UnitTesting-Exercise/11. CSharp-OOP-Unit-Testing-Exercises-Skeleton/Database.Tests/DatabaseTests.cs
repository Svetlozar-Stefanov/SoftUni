using DatabaseMain;
using NUnit.Framework;
using System;
using System.Reflection;

namespace Tests
{
    public class DatabaseTests
    {
        private Database fullDatabase;
        private Database emptyDatabase;
        private Database halfFullDatabase;

        [SetUp]
        public void SetUp()
        {
            fullDatabase = new Database(new int[16]);
            emptyDatabase =new  Database();
            halfFullDatabase =new Database(new int[5]);
        }

        [TearDown]
        public void TearDown()
        {
            fullDatabase = null;
            emptyDatabase = null;
            halfFullDatabase = null;
        }

        [Test]
        public void DatabaseMaxSizeShouldBeSixteen()
        {
            int databaseExpectedSize = 16;

            Assert.That(fullDatabase.Count, Is.EqualTo(databaseExpectedSize), "Capacity is less than 16");
        }

        [Test]
        public void DatabaseMaxSizeShouldNotExceedSixteen()
        {
            Database database = null;

            try
            {
                database = new Database(new int[20]);
            }
            catch (InvalidOperationException)
            {
                Assert.Pass();
            }
            Assert.Fail("Capacity exceeds 16");
        }

        [Test]
        public void AddShouldAddOneElementInDatabase()
        {
            int initialCount = emptyDatabase.Count;

            emptyDatabase.Add(1);

            Assert.That(emptyDatabase.Count, Is.GreaterThan(initialCount), "Couldn`t add element to the database");
        }

        [Test]
        public void AddShouldNotAddElementsOverTheCapacity()
        {
            Assert.That(() => fullDatabase.Add(1), Throws.InvalidOperationException, "Add exceeded the capacity");
        }

        [Test]
        public void RemoveShouldRemoveLastElement()
        { 
            int expectedCount = 15;
            fullDatabase.Remove();
            int actualCount = fullDatabase.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void RemoveShouldntRemoveFromEmptyDatabase()
        {
            Assert.That(() => emptyDatabase.Remove(), Throws.InvalidOperationException, "Removed empty database");
        }

        [Test]
        public void ConstructorShouldOnlyTakeIntegers()
        {
            Type type = halfFullDatabase.GetType();

            ConstructorInfo constructorType = type.GetConstructor(new Type[] { typeof(int[]) });

            Assert.That(constructorType, Is.Not.Null);
        }

        [Test]
        public void FetchShouldReturnArrayData()
        {
            int[] actualData = halfFullDatabase.Fetch();

            Assert.AreEqual(halfFullDatabase.Count ,actualData.Length);
        }
    }
}