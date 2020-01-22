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
    public class BusCompanyService : IBusCompanyService
    {

        private readonly BusTicketSystemContext context;

        public BusCompanyService(BusTicketSystemContext context)
        {
            this.context = context;
        }

        public BusCompany GetBusCompanyById(int busCompanyid)
        {
            var busCompany = context.BusCompanies.First(c => c.BusCompanyId == busCompanyid);
            return busCompany;
        }

        public BusCompany GetBusCompanyByName(string busCompanyName)
        {
            var busCompany = context.BusCompanies.First(c => c.BusCompanyName == busCompanyName);
            return busCompany;
        }
    }
}
