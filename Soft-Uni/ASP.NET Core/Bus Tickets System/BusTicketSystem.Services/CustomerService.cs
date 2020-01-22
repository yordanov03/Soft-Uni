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
    public class CustomerService : ICustomerService
    {

        private readonly BusTicketSystemContext context;

        public CustomerService(BusTicketSystemContext context)
        {
            this.context = context;
        }


        public Customer GetCustomerById(int customerId)
        {
            var customer = context.Customers.First(c => c.CustomerId == customerId);
            return customer;
        }
    }
}
