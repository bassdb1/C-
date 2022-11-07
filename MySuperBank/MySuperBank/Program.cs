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
            var account = new BankAccount("David", 10000);  //making a new object called account, passing in name, and initial balance
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");
            Console.ReadLine();
        }
    }
}
