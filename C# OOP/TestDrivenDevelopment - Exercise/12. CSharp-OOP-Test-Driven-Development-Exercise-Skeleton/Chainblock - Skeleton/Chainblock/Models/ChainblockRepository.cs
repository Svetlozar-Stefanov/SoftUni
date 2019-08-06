using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Chainblock.Contracts;

namespace Chainblock.Models
{
    public class ChainblockRepository : IChainblock
    {
        private List<ITransaction> transactions;

        public ChainblockRepository()
        {
            transactions = new List<ITransaction>();
        }

        public int Count => transactions.Count;

        public void Add(ITransaction tx)
        {
            if (tx == null)
            {
                throw new ArgumentException("Cannot add null");
            }
            if (transactions.Contains(tx))
            {
                throw new ArgumentException("Cannot add existing transaction");
            }

            transactions.Add(tx);
        }

        public void ChangeTransactionStatus(int id, TransactionStatus newStatus)
        {
            if (id < 0)
            {
                throw new ArgumentException("Id cannot be negative");
            }
            if (!transactions.Any(t => t.Id == id))
            {
                throw new ArgumentException("Non existent id");
            }

            transactions.FirstOrDefault(t => t.Id == id).Status = newStatus;
        }

        public bool Contains(ITransaction tx)
        {
            if (tx == null)
            {
                throw new ArgumentException("Doesnt accept null");
            }

            return transactions.Contains(tx);
        }

        public bool Contains(int id)
        {
            if (id < 0)
            {
                throw new ArgumentException("Id cannot be negative");
            }
            return transactions.Any(t => t.Id == id);
        }

        public IEnumerable<ITransaction> GetAllInAmountRange(double lo, double hi)
        {
            if (lo < 0 || hi < 0)
            {
                throw new ArgumentException("Values cannot be negatev");
            }

            return transactions.Where(t => t.Amount >= lo && t.Amount <= hi).ToList();
        }

        public IEnumerable<ITransaction> GetAllOrderedByAmountDescendingThenById()
        {
            return transactions.OrderByDescending(t => t.Amount).ThenBy(t => t.Id);
        }

        public IEnumerable<string> GetAllReceiversWithTransactionStatus(TransactionStatus status)
        {
            List<string> senders = new List<string>();

            var senderTransaction = transactions.Where(t => t.Status == status);

            if (senderTransaction.Count() == 0)
            {
                throw new InvalidOperationException("Cannot find valid transactions");
            }

            foreach (var transaction in senderTransaction.OrderBy(t => t.Amount))
            {
                senders.Add(transaction.To);
            }

            return senders;
        }

        public IEnumerable<string> GetAllSendersWithTransactionStatus(TransactionStatus status)
        {
            List<string> senders = new List<string>();

            var senderTransaction = transactions.Where(t => t.Status == status);

            if (senderTransaction.Count() == 0)
            {
                throw new InvalidOperationException("Cannot find valid transactions");
            }

            foreach (var transaction in senderTransaction.OrderBy(t => t.Amount))
            {
                senders.Add(transaction.From);
            }

            return senders;
        }

        public ITransaction GetById(int id)
        {
            if (id < 0)
            {
                throw new ArgumentException("Id cannot be negative");
            }
            if (!transactions.Any(t => t.Id == id))
            {
                throw new InvalidOperationException("Cannot find Id");
            }

            return transactions.FirstOrDefault(t => t.Id == id);
        }

        public IEnumerable<ITransaction> GetByReceiverAndAmountRange(string receiver, double lo, double hi)
        {
            List<ITransaction> resultTransactions = transactions.Where(t => t.To == receiver && t.Amount >= lo && t.Amount <= hi).ToList();

            if (resultTransactions.Count == 0)
            {
                throw new InvalidOperationException("No transactions found");
            }

            return resultTransactions;
        }

        public IEnumerable<ITransaction> GetByReceiverOrderedByAmountThenById(string receiver)
        {
            if (!transactions.Any(t => t.To == receiver))
            {
                throw new InvalidOperationException("No reciever found");
            }

            return transactions.Where(t => t.To == receiver).OrderByDescending(t => t.Amount).ThenBy(t => t.Id);
        }

        public IEnumerable<ITransaction> GetBySenderAndMinimumAmountDescending(string sender, double amount)
        {
            if (!transactions.Any(t => t.From == sender) || transactions.All(t => t.From == sender && t.Amount < amount))
            {
                throw new InvalidOperationException("No sender found");
            }

            return transactions.Where(t => t.From == sender && t.Amount > amount).OrderByDescending(t => t.Amount);
        }

        public IEnumerable<ITransaction> GetBySenderOrderedByAmountDescending(string sender)
        {
            List<ITransaction> resultTransactions = new List<ITransaction>();

            resultTransactions.AddRange(transactions.Where(t => t.From == sender));

            if (resultTransactions.Count == 0)
            {
                throw new InvalidOperationException("No senders found");
            }

            return resultTransactions.OrderByDescending(t => t.Amount);
        }

        public IEnumerable<ITransaction> GetByTransactionStatus(TransactionStatus status)
        {
            List<ITransaction> resultTransactions = new List<ITransaction>();

            resultTransactions.AddRange(transactions.Where(t => t.Status == status));

            if (resultTransactions.Count == 0)
            {
                throw new InvalidOperationException("No transactions with this status");
            }

            return resultTransactions.OrderByDescending(t => t.Amount);
        }

        public IEnumerable<ITransaction> GetByTransactionStatusAndMaximumAmount(TransactionStatus status, double amount)
        {
            return transactions.Where(t => t.Status == status && t.Amount <= amount);
        }

        public IEnumerator<ITransaction> GetEnumerator()
        {
            return transactions.GetEnumerator();
        }

        public void RemoveTransactionById(int id)
        {
            if (id < 0)
            {
                throw new ArgumentException("Id cannot be negative");
            }

            ITransaction transaction = transactions.FirstOrDefault(t => t.Id == id);

            if (transaction == null)
            {
                throw new InvalidOperationException("Cannot find non existant id");
            }

            transactions.Remove(transaction);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return transactions.GetEnumerator();
        }
    }
}
