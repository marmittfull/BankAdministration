using System;

namespace BankAdministration
{
    class Program
    {
        static void Main(string[] args)
        {

            var bank = new Bank();

            Console.WriteLine("*** Hello to the God's Bank ***");

            var myAccount = new Account("Tiago", bank.IncrementLastAccountNumber());

            Console.WriteLine($"{myAccount.Owner}'s account was created succesfully!");
            Console.WriteLine($"Number: {myAccount.Number}");

            try
            {
                myAccount.MakeDeposit(2000, "October investment");
            } catch(ArgumentException err)
            {
                Console.WriteLine(err.Message);
            }

            try
            {
                myAccount.MakeWithdraw(500, "Gas");
            } catch(ArgumentException err)
            {
                Console.WriteLine(err.Message);
            }

            Console.WriteLine(myAccount.GetTransactionsHistory());
        }
    }    
}