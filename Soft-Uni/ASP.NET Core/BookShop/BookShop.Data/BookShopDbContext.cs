using BookShop.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop.Data
{
    public class BookShopDbContext:IdentityDbContext<Author>
    {
        public BookShopDbContext(DbContextOptions<BookShopDbContext>options) : base(options) { }


        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CategoryBook>().HasKey(cb => new { cb.BookId, cb.CategoryId });
            builder.Entity<CategoryBook>().HasOne(cb => cb.Category).WithMany(c => c.Books).HasForeignKey(cb => cb.CategoryId);
            builder.Entity<CategoryBook>().HasOne(cb => cb.Book).WithMany(a => a.Categories).HasForeignKey(cb => cb.BookId);
            builder.Entity<Book>().Property(b => b.Price).HasColumnType("decimal");
            base.OnModelCreating(builder);
        }
    }
}
