using Microsoft.EntityFrameworkCore.Design;
using CameraBazaar2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace CameraBazaar2.Data
{
    public class CameraBazaarDbContext : IdentityDbContext<User>
    {
        public CameraBazaarDbContext(DbContextOptions<CameraBazaarDbContext> options)
            : base(options)
        {
        }

        public DbSet<Camera> Cameras { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Camera>()
                .Property(c => c.Price)
                .HasColumnType("decimal(18, 2)");

            builder.Entity<User>().HasMany(u => u.Cameras).WithOne(c => c.User).HasForeignKey(c => c.UserId);

            base.OnModelCreating(builder);
        }
    }
}
