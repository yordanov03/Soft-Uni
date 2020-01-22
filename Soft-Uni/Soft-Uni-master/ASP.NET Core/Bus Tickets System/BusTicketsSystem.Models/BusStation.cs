using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketsSystem.Models
{
    public class BusStation
    {
        public BusStation()
        {
           
        }
        public int BusStationId { get; set; }
        public string BusStationName { get; set; }
        public int TownId { get; set; }
        public Town Town { get; set; }
        public ICollection<Trip> DepartureTrips { get; set; } = new List<Trip>();
        public ICollection<Trip> ArrivalTrips { get; set; } = new List<Trip>();
        public ICollection<Trip> OriginTrips { get; set; } = new List<Trip>();
        public ICollection<Trip> DestinationTrips { get; set; } = new List<Trip>();
    }
}
