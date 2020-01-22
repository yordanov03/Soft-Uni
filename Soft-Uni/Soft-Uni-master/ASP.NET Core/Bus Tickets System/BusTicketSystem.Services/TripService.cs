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
    public class TripService : ITripService
    {
        private readonly BusTicketSystemContext context;

        public TripService(BusTicketSystemContext context)
        {
            this.context = context;
        }

        public Trip GetTripById(int tripId)
        {
            var trip = context.Trips.First(t => t.TripId == tripId);
            return trip;
        }
    }
}
