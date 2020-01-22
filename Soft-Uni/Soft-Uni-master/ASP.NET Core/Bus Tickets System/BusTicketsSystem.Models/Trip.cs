using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusTicketsSystem.Models.Enums;

namespace BusTicketsSystem.Models
{
    public class Trip
    {
        public Trip()
        {

        }

        public int TripId { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public Status Status { get; set; }
        public int OriginBusStationId { get; set; }
        public BusStation OriginBusStation { get; set; }
        public int DestinationBusStationId { get; set; }
        public BusStation DestinationBusStation { get; set; }
        public int BusComanyId { get; set; }
        public BusCompany BusCompany { get; set; }
        public ICollection<Ticket> TripTickets { get; set; } = new List<Ticket>();
    }
}
