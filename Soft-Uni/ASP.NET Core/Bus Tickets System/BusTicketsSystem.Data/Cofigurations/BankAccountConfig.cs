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
    public class BankAccountConfig : IEntityTypeConfiguration<BankAccount>
    {
        public void Configure(EntityTypeBuilder<BankAccount> builder)
        {
            builder.ToTable("BankAccounts");

            builder.HasKey(e => e.BankAccountId);
            builder.Property(e => e.BankAccountNumber).IsRequired().IsUnicode(false);
            builder.Property(e => e.Balance).IsRequired();

            builder.HasOne(ba => ba.Customer).WithOne(c => c.BankAccount).HasForeignKey<BankAccount>(ba => ba.CustomerId);
        }
    }
}
