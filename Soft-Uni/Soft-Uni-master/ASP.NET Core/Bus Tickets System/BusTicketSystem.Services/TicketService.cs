using System;
using System.Collections.Generic;
using System.Text;
using BusTicketsSystem.Models;
using BusTicketsSystem.Services.Interfaces;
using BusTicketsSystem.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BusTicketsSystem.Services
{
    public class TicketService : ITicketService
    {
        private readonly BusTicketSystemContext context;
        private readonly ICustomerService customerService;
        private readonly ITripService tripService;

        public TicketService(BusTicketSystemContext context, ICustomerService customerService, ITripService tripService)
        {
            this.context = context;
            this.customerService = customerService;
            this.tripService = tripService;
        }


        public Ticket BuyTicket(Customer customer, Trip trip, decimal price, string seat)
        {
            Ticket ticket = new Ticket{Customer = customer,Trip = trip, Price = price, Seat = seat};
            context.Tickets.Add(ticket);
            context.SaveChanges();
            return ticket;
        }

        public Ticket GetTicketById(int ticketId)
        {
            var ticket = context.Tickets.First(t => t.TicketId == ticketId);
            return ticket;
        }
    }
}
