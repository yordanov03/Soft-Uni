using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketsSystem.Models
{
    public class BusCompany
    {
        public BusCompany()
        {

        }
        public int BusCompanyId { get; set; }
        public string BusCompanyName { get; set; }
        public string Nationality { get; set; }
        public double Rating { get; set; }
        public ICollection<Review> Reviews { get; set; } = new List<Review>();

    }

}
