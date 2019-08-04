using ExtendedDatabaseMain;
using NUnit.Framework;
using System;
using System.Reflection;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase testDatabase;

        [SetUp]
        public void SetUp()
        {
            testDatabase = new ExtendedDatabase(GetPeople(2));
        }

        [Test]
        public void ConstructorInitializesCorrectly()
        {
            int expectedResult = 2;

            ExtendedDatabase extendedDatabase = new ExtendedDatabase(GetPeople(2));

            int actualResult = extendedDatabase.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void ConstructorShouldntAcceptArraysBiggerThanCapacity()
        {
            Assert.That(() => new ExtendedDatabase(GetPeople(17)), Throws.ArgumentException);
        }

        [Test]
        public void TestConstructorShouldThrowExceptionWithEmptyPeople()
        {
            Person[] people = new Person[17];

            Assert.That(() => new ExtendedDatabase(people), Throws.ArgumentException);
        }

        [Test]
        public void AddShouldExecuteCorrectly()
        {
            int expectedResult = 3;

            testDatabase.Add(new Person(23, "sasho roman"));

            int actualResult = testDatabase.Count;

            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void AddShouldNotAddExistingNamePerson()
        {
            Assert.That(() => testDatabase.Add(new Person(5, "pencho 1")), Throws.InvalidOperationException, "Sholdnt add existing name person");
        }

        [Test]
        public void AddShouldNotAddExistingIdPerson()
        {
            Assert.That(() => testDatabase.Add(new Person(1, "pencho 29")), Throws.InvalidOperationException, "Sholdnt add existing id person");
        }

        [Test]
        public void AddShouldNotAddElementsOverTheCapacity()
        {
            ExtendedDatabase extendedDatabase = new ExtendedDatabase(GetPeople(16));

            Assert.That(() => extendedDatabase.Add(new Person(45, "Koicho")), Throws.InvalidOperationException, "Add exceeded the capacity");
        }


        [Test]
        public void RemoveShouldRemoveLastElement()
        {
            int expectedCount = 1;
            testDatabase.Remove();
            int actualCount = testDatabase.Count;

            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void RemoveShouldntRemoveFromEmptyDatabase()
        {
            ExtendedDatabase extendedDatabase = new ExtendedDatabase();

            Assert.That(() => extendedDatabase.Remove(), Throws.InvalidOperationException, "Removed empty database");
        }

        [Test]
        public void FindByNameShouldntFindNull()
        {
            Assert
                .That(() => testDatabase.FindByUsername(null)
                , Throws.ArgumentNullException, "Shouldnt process null");
        }

        [Test]
        public void FindByNameShouldntFindNonExistentPerson()
        {
            string testUser = "gosho 234";

            Assert
                .That(() => testDatabase.FindByUsername(testUser)
                , Throws.InvalidOperationException, "Shouldnt find non - existent person");
        }

        [Test]
        public void FindByNameArgumentsShouldBeCaseSensitive()
        {
            string name = "koicho";

            testDatabase.Add(new Person(123, name));

            Assert.That(() => testDatabase.FindByUsername(name.ToUpper())
                , Throws.InvalidOperationException, "Should be case sensitive");
        }

        [Test]
        public void FindByNameSholdReturnCorrectPerson()
        {
            Person expectedResult = new Person(20, "pencho 20");

            testDatabase.Add(expectedResult);

            Person actualResult = testDatabase.FindByUsername(expectedResult.UserName);

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void FindByIdShouldntFindNonExistentPerson()
        {
            int fakeId = 4568;
            Assert
                .That(() => testDatabase.FindById(fakeId)
                , Throws.InvalidOperationException, "Shouldnt find non - existent id person");
        }

        [Test]
        public void FindByIdShouldntFindNegativeIds()
        {
            //int negativeId = -1;
            Assert.Throws<ArgumentOutOfRangeException>(() => testDatabase.FindById(-1),"Id is negative");
        }

        [Test]
        public void FindByIdShouldReturnPerson()
        {
            Person expectedResult = new Person(20, "pencho 20");

            testDatabase.Add(expectedResult);

            Person actualResult = testDatabase.FindById(expectedResult.Id);

            Assert.AreEqual(expectedResult, actualResult);
        }

        private Person[] GetPeople(int countOfPeople)
        {
            Person[] people = new Person[countOfPeople];

            for (int i = 0; i < countOfPeople; i++)
            {
                people[i] = new Person(i, "pencho " + i);
            }

            return people;
        }
    }
}