using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
   public  class BankAccount
    {
        // Both the 'Properties' and the 'Functions' are members of the BankAccount Class

        // Properties
        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { 
            get
            {
                decimal balance = 0;  //initial balance of 0
                foreach (var item in allTransactions)
                {
                    balance = balance + item.Amount;
                }
                return balance;
            }
        
        }

        private static int accountNumberSeed = 1234567890;  // seed ir referenced as a number that is a starting point

        private List<Transaction> allTransactions = new List<Transaction>();   // This List sets aside a portion of memory, and make a new object

        //Constructor, has to be the same name as the class, constructors are good at setting initial values for the 'properties' of the class
        public BankAccount(string name, decimal initialBalance)  // what we are passing into our 'Properties' for our class
        {
            this.Owner = name;  // Owner is a property, name we are passing in
            MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;  // I am adding one to the next accountNumberSeed, we can't have the same bank account number for each person

        }


        //Functions
        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                // all things stop running when an exception is thrown - so after this line, nothing is ran, like a break

                throw new ArgumentOutOfRangeException(nameof(amount), "Amout of deposit must be positive");  
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);


        }

        public void MakeWithDrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                // all things stop running when an exception is thrown - so after this line, nothing is ran, like a break

                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawl must be postive ");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawl");
            }
            var withdrawl = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawl);

        }
    }
}
