using System;
using System.Collections.Generic;
using System.Text;
using BusTicketsSystem.Models;

namespace BusTicketsSystem.Services.Interfaces
{
    public interface ITicketService
    {
        Ticket GetTicketById(int ticketId);
        Ticket BuyTicket(Customer customer, Trip trip, decimal ticketPrice, string seat);
    }
}
