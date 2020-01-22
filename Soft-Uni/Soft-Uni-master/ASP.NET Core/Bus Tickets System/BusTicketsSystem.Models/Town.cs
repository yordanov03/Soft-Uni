using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketsSystem.Models
{
    public class Town
    {
        public Town()
        {

        }

        public int TownId { get; set; }
        public string TownName { get; set; }
        public string Country { get; set; }
        public ICollection<Customer> Customers { get; set; } = new List<Customer>();
        public ICollection<BusStation> BusStations { get; set; } = new List<BusStation>();
    }
}
