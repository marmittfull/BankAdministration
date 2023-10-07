using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAdministration
{
    public class Transaction
    {
        public DateTime Date { get; }
        public string Notes { get; }
        public decimal Amount { get; }

        public Transaction(string notes, decimal amount)
        {
            this.Date = DateTime.Now;
            this.Notes = notes;
            this.Amount = amount;
        }
    }
}
