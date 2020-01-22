using System;
using System.Collections.Generic;
using System.Text;
using BusTicketsSystem.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using BusTicketsSystem.Data;

namespace BusTicketsSystem.Services
{
    public class DatabaseService : IDatabaseService
    {
       private readonly BusTicketSystemContext context;

        public DatabaseService(BusTicketSystemContext context)
        {
            this.context = context;
        }

        public void InitializeDatabase()
        {
            this.context.Database.EnsureDeleted();
            this.context.Database.Migrate();

            Console.WriteLine("Database is initialized!");

        }
    }
}
