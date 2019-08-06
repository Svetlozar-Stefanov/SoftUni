using Chainblock.Contracts;
using Chainblock.Models;
using NUnit.Framework;
using System;

namespace Chainblock.Tests
{
    [TestFixture]
    public class TransactionTests
    {
        private const int testId = 3;
        private const TransactionStatus testStatus = TransactionStatus.Successfull;
        private const string testFrom = "Sam";
        private const string testTo = "Gabe";
        private const double testAmount = 2.99;

        [Test]
        public void ConstructorShouldInitializeCorrectly()
        {
            ITransaction transaction = new Transaction(testId, testStatus, testFrom, testTo, testAmount);

            Assert.AreEqual(testId, transaction.Id);
            Assert.AreEqual(testStatus, transaction.Status);
            Assert.AreEqual(testFrom, transaction.From);
            Assert.AreEqual(testTo, transaction.To);
            Assert.AreEqual(testAmount, transaction.Amount);
        }

        [Test]
        [TestCase(-1)]
        public void IdCannotBeZeroOrNegative(int id)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ITransaction transaction = new Transaction(id, testStatus, testFrom, testTo, testAmount);
            });
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void TestCannotBeNullOrEmpty(string from)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ITransaction transaction = new Transaction(testId, testStatus, from, testTo, testAmount);
            });
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        public void ToCannotBeNullOrEmpty(string to)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ITransaction transaction = new Transaction(testId, testStatus, testFrom, to, testAmount);
            });
        }

        [Test]
        [TestCase(-1)]
        public void AmountCannotBeZeroOrNegative(double amount)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                ITransaction transaction = new Transaction(testId, testStatus, testFrom, testTo, amount);
            });
        }
    }
}
