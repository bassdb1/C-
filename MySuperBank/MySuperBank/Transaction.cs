using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    class Transaction
    {
        // Properties for the Transaction Class
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }


        // Transaction Contructor, used to set intital values, for my Transaction Properties

        public Transaction(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;     // ths means the current instance.
            this.Date = date;
            this.Notes = note;
        }

    }
}
