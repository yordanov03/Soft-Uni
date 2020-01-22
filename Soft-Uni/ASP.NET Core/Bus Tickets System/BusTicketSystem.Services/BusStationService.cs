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
    public class BusStationService : IBusStationService
    {
        private readonly BusTicketSystemContext context;

        public BusStationService(BusTicketSystemContext context)
        {
            this.context = context;
        }

        public BusStation GetBusStationById(int BusStationId)
        {
            var busStation = context.BusStations.First(bs => bs.BusStationId == BusStationId);
            return busStation;
        }
    }
}
