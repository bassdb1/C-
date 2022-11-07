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
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance = balance + item.Amount;
                }
                return balance;
            }
        
        
        
        
        }

        private static int accountNumberSeed = 1234567890;

        private List<Transaction> allTransactions = new List<Transaction>();   // This List sets aside a portion of memory, and make a new object

        //Constructor, has to be the same name as the class, constructors are good at setting initial values
        public BankAccount(string name)  // what we are passing into our 'Properties' for our class
        {
            this.Owner = name;  // Owner is a property, name we are passing in
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;  // I am adding one to the next accountNumberSeed, we can't have the same bank account number for each person

        }


        //Functions
        public void MakeDeposit(decimal anount, DateTime date, string note)
        {

        }

        public void MakeWithDrawal(decimal amount, DateTime date, string note)
        {

        }
    }
}
