namespace Telecom.Tests
{
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class Tests
    {
        private string testMake = "Samsung";
        private string testModel = "G7";

        private Phone phone;

        [SetUp]
        public void SetUp()
        {
            phone = new Phone(testMake, testModel);
        }

        [Test]
        public void ConstructorShouldInitializeCorrectly()
        {
            Phone phone = new Phone(testMake, testModel);

            Assert.AreEqual(testMake, phone.Make);
            Assert.AreEqual(testModel, phone.Model);
            Assert.AreEqual(0, phone.Count);
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void MakeCannotBeNullOrEmpty(string make)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Phone phone = new Phone(make, testModel);
            });
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        public void ModelCannotBeNullOrEmpty(string model)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                Phone phone = new Phone(testMake, model);
            });
        }

        [Test]
        public void AddContactShouldWorkCorrectly()
        {
            phone.AddContact("Bob", "123456789");

            Assert.AreEqual(1, phone.Count);
        }

        [Test]
        public void AddContactCannotAddExistingContact()
        {
            phone.AddContact("Bob", "123456789");

            Assert.Throws<InvalidOperationException>(() =>
            {
                phone.AddContact("Bob", "123456789");
            });
        }

        [Test]
        public void CallShouldWorkCorrectly()
        {
            phone.AddContact("Bob", "123456789");

            Assert.AreEqual("Calling Bob - 123456789...", phone.Call("Bob"));
        }

        [Test]
        public void CallCannotCallNotExistantNumber()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                phone.Call("Bob");
            });
        }
    }
}