using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusTicketsSystem.Models
{
    public class Review
    {
        public Review()
        {

        }
        public int ReviewId { get; set; }
        public string ReviewContent { get; set; }
        [Range(1,10)]
        public float Grade { get; set; }
        public int BusCompanyId { get; set; }
        public BusCompany BusCompany { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime DateTimeOfPublishing { get; set; }
    }
}
