using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Bank
{
    public class Account
    {
        public List<Transaction> Transactions { get; private set; } = new List<Transaction>();
        public static decimal TotalIncome { get;  set; }
        public static decimal TotalExpenses { get;  set; }

        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
            transaction.ProcessTransaction();
        }
    }
}
