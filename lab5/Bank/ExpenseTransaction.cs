using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5.Bank
{
    public class IncomeTransaction : Transaction
    {
        public IncomeTransaction(decimal amount, DateTime transactionDate) : base(amount, transactionDate)
        {
        }

        public override void ProcessTransaction()
        {
            Account.TotalIncome += Amount;
        }
    }
}
