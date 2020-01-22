using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketsSystem.Models
{
    public class BankAccount
    {
        public BankAccount()
        {

        }

        public int BankAccountId { get; set; }
        public string BankAccountNumber { get; set; }
        public decimal Balance { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
