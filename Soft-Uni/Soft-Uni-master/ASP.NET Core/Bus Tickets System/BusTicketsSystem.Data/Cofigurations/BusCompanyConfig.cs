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
    public class BusCompanyConfig : IEntityTypeConfiguration<BusCompany>
    {
        public void Configure(EntityTypeBuilder<BusCompany> builder)
        {
            builder.ToTable("BusCompanies");

            builder.HasKey(e => e.BusCompanyId);
            builder.Property(e => e.BusCompanyName).IsRequired().IsUnicode().HasMaxLength(250);

            builder.HasMany(bc => bc.Reviews).WithOne(r => r.BusCompany).HasForeignKey(r => r.ReviewId);
            
        }
    }
}
