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
    public class TownConfig : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> builder)
        {
            builder.ToTable("Towns");

            builder.HasKey(e => e.TownId);
            builder.Property(e => e.TownName).IsRequired().IsUnicode().HasMaxLength(50);
            builder.Property(e => e.Country).IsRequired().IsUnicode().HasMaxLength(50);

        }
    }
}
