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
    public class TripConfig : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.ToTable("Trips");

            builder.HasKey(e => e.TripId);
            builder.Property(e => e.DepartureTime).IsRequired().HasColumnType("DATETIME2");
            builder.Property(e => e.ArrivalTime).IsRequired().HasColumnType("DATETIME2");
            builder.Property(e => e.Status).IsRequired();

            builder.HasOne(e => e.DestinationBusStation).WithMany(e => e.ArrivalTrips).HasForeignKey(e => e.DestinationBusStationId);
            builder.HasOne(e => e.OriginBusStation).WithMany(e => e.DepartureTrips).HasForeignKey(e => e.OriginBusStationId);
        }
    }
}
