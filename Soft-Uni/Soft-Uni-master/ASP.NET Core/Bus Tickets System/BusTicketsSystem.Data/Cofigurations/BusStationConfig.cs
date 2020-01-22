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
    public class BusStationConfig : IEntityTypeConfiguration<BusStation>
    {
        public void Configure(EntityTypeBuilder<BusStation> builder)
        {
            builder.ToTable("BusStations");

            builder.HasKey(e => e.BusStationId);
            builder.Property(e => e.BusStationName).IsRequired().IsUnicode().HasMaxLength(50);

            builder.HasOne(e => e.Town).WithMany(e => e.BusStations).HasForeignKey(e => e.TownId);
        }
    }
}
