using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAdministration
{
    public class Bank
    {
        public long LastAccountNumber { get; set; }

        public Bank()
        {
            LastAccountNumber = 0;
        }

        public long GetLastAccountNumber()
        {
            return this.LastAccountNumber;
        }

        public long IncrementLastAccountNumber()
        {
            this.LastAccountNumber += 1;
            return this.LastAccountNumber;
        }
    }
}
