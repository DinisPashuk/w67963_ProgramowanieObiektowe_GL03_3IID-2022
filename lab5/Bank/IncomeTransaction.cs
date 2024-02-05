using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Bank
{
    public class ExpenseTransaction : Transaction
    {
        public ExpenseTransaction(decimal amount, DateTime transactionDate) : base(amount, transactionDate)
        {
        }

        public override void ProcessTransaction()
        {
            Account.TotalExpenses += Amount;
        }
    }
}

