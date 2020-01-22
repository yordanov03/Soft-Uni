using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BusTicketsSystem.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusTicketsSystem.Data.Cofigurations
{
    public class TicketConfig : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.ToTable("Tickets");

            builder.HasKey(e => e.TicketId);
            builder.Property(e => e.Price).IsRequired();
            builder.Property(e => e.Seat).IsRequired();
            builder.HasOne(e => e.Customer).WithMany(e => e.AllTicketsOwned).HasForeignKey(e => e.CustomerId);
            builder.HasOne(e => e.Trip).WithMany(e => e.TripTickets).HasForeignKey(e => e.TripId);
        }
    }
}
