using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTicketsSystem.Models.Enums;

namespace BusTicketsSystem.Models
{
   public class Customer
    {
        public Customer()
        {

        }
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public int TownId { get; set; }
        public Town HomeTown { get; set; }
        public ICollection<Ticket> AllTicketsOwned { get; set; } = new List<Ticket>();
        public ICollection<Review> ReviewsWritten { get; set; } = new List<Review>();
        public int BankAccountId { get; set; }
        public BankAccount BankAccount { get; set; }
    }
}
