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
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            builder.HasKey(e => e.CustomerId);
            builder.Property(e => e.FirstName).IsUnicode().IsRequired();
            builder.Property(e => e.LastName).IsUnicode().IsRequired();
            builder.Property(e => e.DateOfBirth).IsRequired().HasMaxLength(50).HasColumnType("DATETIME2");

            builder.HasOne(e => e.HomeTown).WithMany(e => e.Customers).HasForeignKey(e => e.TownId);
        }
    }
}
