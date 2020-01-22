using System;
using System.Collections.Generic;
using System.Text;
using BusTicketsSystem.Client.Core.Commands.Contracts;
using BusTicketsSystem.Models;
using BusTicketsSystem.Services;
using BusTicketsSystem.Services.Interfaces;

namespace BusTicketsSystem.Client.Core.Commands
{
    public class BuyTicketCommand : ICommand
    {
        private readonly ITicketService ticketService;
        private readonly ICustomerService customerService;
        private readonly ITripService tripService;

        public BuyTicketCommand(ITicketService ticketService, ICustomerService customerService, ITripService tripService)
        {
            this.ticketService = ticketService;
            this.customerService = customerService;
            this.tripService = tripService;
        }

        public string Execute(params string[] data)
        {
            int customerId = int.Parse(data[0]);
            int tripId = int.Parse(data[1]);
            decimal ticketPrice = decimal.Parse(data[2]);
            var seat = data[3];

            Customer customer = customerService.GetCustomerById(customerId);
            var customerMoney = customer.BankAccount.Balance;

            if (customerMoney< ticketPrice)
            {
                throw new InvalidOperationException($"Insufficient amount of money for customer {customer.FirstName} {customer.LastName} " +
                    $"with bank account number {customer.BankAccount.BankAccountNumber}");
            }
            if (ticketPrice<0)
            {
                throw new InvalidOperationException("Invalid price");
            }
            customerMoney -= ticketPrice;
            Trip trip = tripService.GetTripById(tripId);
            ticketService.BuyTicket(customer, trip, ticketPrice, seat);
            return $"Customer {customer.FirstName} {customer.LastName} bought ticket for trip {trip.TripId} for {ticketPrice} on seat {seat}";
        }
    }
}
