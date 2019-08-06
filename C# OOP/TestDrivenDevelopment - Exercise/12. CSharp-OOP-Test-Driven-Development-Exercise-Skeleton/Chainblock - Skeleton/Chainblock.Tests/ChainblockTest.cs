using Chainblock.Contracts;
using Chainblock.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Chainblock.Tests
{
    [TestFixture]
    public class ChainblockTest
    {
        private IChainblock transactions;
        private ITransaction transaction;

        [SetUp]
        public void SetUp()
        {
            transactions = new ChainblockRepository();
            transaction = new Transaction(5, TransactionStatus.Successfull, "Bob", "Gabe", 2.99);
        }

        [Test]
        public void ConstructorShouldInitializeCorrectly()
        {
            IChainblock transactions = new ChainblockRepository();

            Assert.AreEqual(0, transactions.Count);
        }

        [Test]
        public void AddShouldExecuteCorrectly()
        {
            int expectedCount = 1;

            transactions.Add(transaction);

            Assert.AreEqual(expectedCount, transactions.Count);
            Assert.That(transactions.Contains(transaction));
        }

        [Test]
        public void AddShouldNotAddExistingTransaction()
        {
            transactions.Add(transaction);

            Assert.Throws<ArgumentException>(() =>
            {
                transactions.Add(transaction);
            });
        }

        [Test]
        public void AddShouldNotAddNull()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                transactions.Add(null);
            });
        }

        [Test]
        public void ContainsShouldReturnCorrectResult()
        {
            transactions.Add(transaction);

            Assert.That(transactions.Contains(transaction));
        }

        [Test]
        public void ContainsShouldReturnFalseIfTransactionDoesntExist()
        {
            Assert.That(!transactions.Contains(transaction));
        }

        [Test]
        public void ContainsCannotAcceptNull()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                transactions.Contains(null);
            });
        }

        [Test]
        public void ContainsIdShouldReturnCorrectResult()
        {
            transactions.Add(transaction);

            Assert.That(transactions.Contains(transaction.Id));
        }

        [Test]
        public void ContainsIdShouldReturnFalseIfTransactionDoesntExist()
        {
            Assert.That(!transactions.Contains(transaction.Id));
        }

        [Test]
        public void ContainsIdCannotAcceptNull()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                transactions.Contains(null);
            });
        }

        [Test]
        public void ChangeTransactionStatusShouldWorkCorrectly()
        {
            transactions.Add(transaction);

            transactions.ChangeTransactionStatus(transaction.Id, TransactionStatus.Failed);

            Assert.AreEqual(TransactionStatus.Failed, transactions.First().Status);
        }

        [Test]
        public void ChangeTransactionStatusShouldntChangeNonExistentId()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                transactions.ChangeTransactionStatus(transaction.Id, TransactionStatus.Failed);
            });
        }

        [Test]
        public void ChangeTransactionStatusShouldntAcceptNegativeIds()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                transactions.ChangeTransactionStatus(-1, TransactionStatus.Failed);
            });
        }

        [Test]
        public void RemoveByIdSholdWorkCorrectly()
        {
            int expectedCount = 0;

            transactions.Add(transaction);

            transactions.RemoveTransactionById(transaction.Id);

            Assert.AreEqual(expectedCount, transactions.Count);
            Assert.That(!transactions.Contains(transaction));
        }

        [Test]
        public void RemoveCannotRemoveNonExistentIds()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                transactions.RemoveTransactionById(transaction.Id);
            });
        }

        [Test]
        public void RemoveCannotRemoveNegativeId()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                transactions.RemoveTransactionById(-1);
            });
        }

        [Test]
        public void GetByIdSholdWorkCorrectly()
        {
            transactions.Add(transaction);

            

            Assert.AreEqual(transaction , transactions.GetById(transaction.Id));
        }

        [Test]
        public void GetByIdCannotFindNonExistentIds()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                transactions.GetById(transaction.Id);
            });
        }

        [Test]
        public void GetByIdCannotFindNegativeId()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                transactions.GetById(-1);
            });
        }

        [Test]
        public void GetByStatusShouldWorkCorrectly()
        {
            ITransaction transaction2 = new Transaction(2, TransactionStatus.Successfull, "Acho", "Koicho", 4.56);

            transactions.Add(transaction);
            transactions.Add(transaction2);

            var resultTransitions = transactions.GetByTransactionStatus(TransactionStatus.Successfull);

            Assert.AreEqual(2, resultTransitions.Count());

            Assert.That(resultTransitions.Contains(transaction));
            Assert.That(resultTransitions.Contains(transaction2));
        }

        [Test]
        public void GetByStatusShouldThrowExcIfNoTransactionsWithStatus()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                transactions.GetByTransactionStatus(TransactionStatus.Failed);
            });
        }

        [Test]
        public void GetAllSendersWithTransactionStatusShouldWorkCorrectly()
        {
            ITransaction transaction2 = new Transaction(2, TransactionStatus.Successfull, "Acho", "Koicho", 4.56);

            transactions.Add(transaction);
            transactions.Add(transaction2);

            var resultSenders = transactions.GetAllSendersWithTransactionStatus(TransactionStatus.Successfull);
        }

        [Test]
        public void GetAllSendersWithTransactionStatusShouldFindNonExistingSenders()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                transactions.GetAllSendersWithTransactionStatus(TransactionStatus.Failed);
            });
        }

        [Test]
        public void GetAllReceiversWithTransactionStatusShouldWorkCorrectly()
        {
            ITransaction transaction2 = new Transaction(2, TransactionStatus.Successfull, "Acho", "Koicho", 4.56);

            transactions.Add(transaction);
            transactions.Add(transaction2);

            var resultSenders = transactions.GetAllReceiversWithTransactionStatus(TransactionStatus.Successfull);
        }

        [Test]
        public void GetAllReceiversWithTransactionStatusShouldFindNonExistingSenders()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                transactions.GetAllReceiversWithTransactionStatus(TransactionStatus.Failed);
            });
        }

        [Test]
        public void GetAllOrderedByAmountDescendingThenById()
        {
            ITransaction transaction2 = new Transaction(2, TransactionStatus.Successfull, "Acho", "Koicho", 4.56);

            transactions.Add(transaction);
            transactions.Add(transaction2);

            List<ITransaction> resultTransactions = new List<ITransaction>();
            resultTransactions.Add(transaction2);
            resultTransactions.Add(transaction);

            Assert.AreEqual(resultTransactions, transactions.GetAllOrderedByAmountDescendingThenById());
        }

        [Test]
        public void GetBySenderOrderedByAmountDescendingShouldExecuteCorrectly()
        {
            ITransaction transaction2 = new Transaction(2, TransactionStatus.Successfull, "Kolio", "Koicho", 4.56);

            transactions.Add(transaction);
            transactions.Add(transaction2);

            var senders = transactions.GetBySenderOrderedByAmountDescending("Bob");

            Assert.That(senders.Contains(transaction));
        }

        [Test]
        public void GetBySenderOrderedByAmountShouldntFindNonExistandSenders()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                transactions.GetBySenderOrderedByAmountDescending("Koilio");
            });
        }

        [Test]
        public void GetRecieverOrderedByAmountDescendingThenById()
        {
            ITransaction transaction2 = new Transaction(2, TransactionStatus.Successfull, "Acho", "Gabe", 4.56);

            transactions.Add(transaction);
            transactions.Add(transaction2);

            List<ITransaction> resultTransactions = new List<ITransaction>();
            resultTransactions.Add(transaction2);
            resultTransactions.Add(transaction);

            Assert.AreEqual(resultTransactions, transactions.GetByReceiverOrderedByAmountThenById("Gabe"));
        }

        [Test]
        public void GetRecieverOrderedByAmountDescendingThenByIdShouldntFindNonExistandSenders()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                transactions.GetByReceiverOrderedByAmountThenById("Koilio");
            });
        }

        [Test]
        public void GetByTransactionStatusAndMaximumAmountShouldWorkCorrectly()
        {
            transactions.Add(transaction);

            var result = new List<ITransaction>();
            result.Add(transaction);

            Assert.AreEqual(result, transactions.GetByTransactionStatusAndMaximumAmount(TransactionStatus.Successfull, 10));
        }

        [Test]
        public void GetBySenderAndMinimumAmountDescendingShouldWorkCorrectly()
        {
            transactions.Add(transaction);

            var result = new List<ITransaction>();
            result.Add(transaction);

            Assert.AreEqual(result, transactions.GetBySenderAndMinimumAmountDescending("Bob", 1));
        }

        [Test]
        public void GetBySenderAndMinimumAmountDescendingCannotFindNonExistingSender()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                transactions.GetBySenderAndMinimumAmountDescending("koicho", 200);
            });
        }

        [Test]
        public void GetByReceiverAndAmountRangeShouldWorkCorrectly()
        {
            transactions.Add(transaction);

            List<ITransaction> result = new List<ITransaction>();
            result.Add(transaction);

            Assert.AreEqual(result, transactions.GetByReceiverAndAmountRange("Gabe", 1, 100));
        }

        [Test]
        public void GetByReceiverAndAmountRangeShouldNotReturnNonExistantRecievers()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                transactions.GetByReceiverAndAmountRange("Gabe", 1, 100);
            });
        }

        [Test]
        public void GetAllInAmountRangeShouldWorkCorrectly()
        {
            transactions.Add(transaction);

            List<ITransaction> result = new List<ITransaction>();
            result.Add(transaction);

            Assert.AreEqual(result, transactions.GetAllInAmountRange(1, 100));
        }

        [Test]
        public void GetAllInAmountRangeShouldntAcceptNegative()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                transactions.GetAllInAmountRange(-1, 100);
            });
        }
    }
}
