using System;
using System.Collections.Generic;
using System.Text;
using BusTicketsSystem.Models;

namespace BusTicketsSystem.Services.Interfaces
{
    public interface ICustomerService
    {
        Customer GetCustomerById(int customerId);
    }
}
