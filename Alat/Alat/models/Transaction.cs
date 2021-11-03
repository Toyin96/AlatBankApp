using System;
using System.Collections.Generic;
using System.Text;

namespace Alat.models
{
    class Transaction
    {

        public string transactionId { get; set; }
        public DateTime date { get; }
        public string description { get; set; }
        public string type { get; set; }
        public decimal amount { get; set; }
        public decimal balance { get; set; }

        public Transaction(string transactionId, DateTime transactionDate, string description,
            string transactionType, decimal amount, decimal balance)
        {
            this.transactionId = transactionId;
            this.date = transactionDate;
            this.description = description;
            this.type = transactionType;
            this.amount = amount;
            this.balance = balance;
        }

        public Transaction(string transactionId, string description, string transactionType,
            decimal amount, decimal balance)
        {
            this.transactionId = transactionId;
            this.description = description;
            this.type = transactionType;
            this.amount = amount;
            this.balance = balance;
        }

        public Transaction()
        {

        }

        public string PerformTransaction()
        {
            if (this.amount < this.balance)
            {
                this.balance -= amount;
                return "Transaction went successfully";
            }
            else
            {
                return "transaction amount can't be larger than available balance";
            }
        }

        public string GetTransactionID()
        {
            return this.transactionId;
        }

        public DateTime GetTransactionDate()
        {
            return this.date;
        }

        public void SetTransactionType(string typeName)
        {
            this.type = typeName;
        }

        public decimal GetTransactionBalance()
        {
            return this.balance;
        }

        ~Transaction()
        {

        }
    }
}
