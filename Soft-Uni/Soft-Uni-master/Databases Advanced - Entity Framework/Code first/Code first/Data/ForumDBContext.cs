using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

using Forum.Data.Models;

namespace Forum.Data
{
    public class ForumDBContext :DbContext
    {
        public ForumDBContext()
        {

        }
        public ForumDBContext(DbContextOptions options) :base (options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Reply> Replies { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<PostTag> PostTags { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.connectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasMany(p => p.Posts).WithOne(c => c.Category).HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<Post>().HasMany(p => p.Replies).WithOne(r => r.Post).HasForeignKey(r => r.PostId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>().HasMany(u => u.Posts).WithOne(p => p.Author).HasForeignKey(p => p.AuthorId);

            modelBuilder.Entity<User>().HasMany(u => u.Replies).WithOne(r => r.Author).HasForeignKey(r => r.AuthorId);

            modelBuilder.Entity<PostTag>().ToTable("PostsTags").HasKey(pt => new { pt.PostId, pt.TagId});

            modelBuilder.Entity<Tag>().ToTable("Tags");

        }
    }
}
