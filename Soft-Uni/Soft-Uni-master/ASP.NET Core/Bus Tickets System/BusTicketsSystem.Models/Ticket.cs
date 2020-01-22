using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketsSystem.Models
{
    public class Ticket
    {
        public Ticket()
        {
              
        }
        public int TicketId { get; set; }
        public decimal Price { get; set; }
        public string Seat { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Trip Trip { get; set; }
        public int TripId { get; set; }
    }
}
