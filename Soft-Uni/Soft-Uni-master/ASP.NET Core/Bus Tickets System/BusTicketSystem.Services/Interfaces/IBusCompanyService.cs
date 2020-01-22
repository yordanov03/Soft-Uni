using System;
using System.Collections.Generic;
using System.Text;
using BusTicketsSystem.Models;

namespace BusTicketsSystem.Services.Interfaces
{
    public interface IBusCompanyService
    {
        BusCompany GetBusCompanyById(int busCompanyid);
        BusCompany GetBusCompanyByName(string busCompanyName);
    }
}
