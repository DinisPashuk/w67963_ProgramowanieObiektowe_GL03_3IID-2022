using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Bank
{
    public abstract class Transaction
    {
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        protected Transaction(decimal amount, DateTime transactionDate)
        {
            Amount = amount;
            TransactionDate = transactionDate;
        }

        public abstract void ProcessTransaction();
    }
}
