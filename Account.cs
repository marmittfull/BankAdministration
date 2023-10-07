using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankAdministration
{
    public class Account
    {
        public long Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get
            {
                decimal currentBalance = 0;
                foreach(var transaction in Transactions)
                {
                    currentBalance += transaction.Amount;
                }
                return currentBalance;
            } 
        }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        public Account(string accountName, long accountNumber)
        {
            this.Owner = accountName;
            this.Number = accountNumber;
        }
        public void MakeDeposit(decimal amount, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("The amount must be positive!");
            }
            Transaction newTransaction = new Transaction(note, amount);
            Transactions.Add(newTransaction);
        }
        public void MakeWithdraw(decimal amount, string note)
        {
            if(amount <= 0)
            {
                throw new ArgumentException("The amout must be positive!");
            }
            else if(this.Balance < amount)
            {
                throw new ArgumentException("You don't have enough funds for this withdraw!");
            }
            Transaction newTransaction = new Transaction(note, -amount);
            Transactions.Add(newTransaction);
        }

        public string GetTransactionsHistory()
        {
            StringBuilder history = new StringBuilder();

            history.AppendLine("Date\t\tAmount\t\tNotes");
            foreach (var transaction in Transactions)
            {
                history.AppendLine($"{transaction.Date.ToShortDateString()}\t{transaction.Amount}\t\t{transaction.Notes}");
            }

            return history.ToString();
        }
    }
}
