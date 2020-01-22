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
    public class ReviewConfig : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.ToTable("Reviews");

            builder.HasKey(e => e.ReviewId);
            builder.Property(e => e.ReviewContent).IsRequired().HasMaxLength(500).IsUnicode();
            builder.Property(e => e.DateTimeOfPublishing).IsRequired().HasColumnType("DATETIME");

            builder.HasOne(r => r.Customer).WithMany(c => c.ReviewsWritten).HasForeignKey(r => r.CustomerId);
            builder.HasOne(r => r.BusCompany).WithMany(c => c.Reviews).HasForeignKey(r => r.ReviewId);

        }
    }
}
