using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)  //entry point for any application
        {
            //making our Bank Account Object - below it is calling the constructor, called 'BankAccount' from the 'BankAccount' class
            var account = new BankAccount("David", 10000);  //making a new object called account, passing in name, and initial balance
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");

            //Make a WithDrawl

            account.MakeWithDrawal(120, DateTime.Now, "Hammock");

            //Display the balance
            Console.WriteLine(account.Balance);

            // Make a Deposit

            account.MakeDeposit(-300, DateTime.Now, "negative deposit");

            Console.ReadLine();
        }
    }
}
