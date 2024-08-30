using Ecommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Ecommerce.Context
{
    public class EcommerceDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;initial Catalog=EcommerceDB;Integrated Security=true;encrypt=false;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(e => e.CategoryName).IsRequired().HasMaxLength(100);
                //entity.HasMany(e => e.products).WithOne().OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.ProductName).IsRequired().HasMaxLength(75);
                entity.Property(p => p.ImageURL).IsRequired();
                entity.Property(p => p.Price).HasColumnType("money");
                entity.Property(p => p.Quantity).IsRequired();
                entity.Property(p => p.ProductDescription).HasMaxLength(500);
                // entity.HasOne(e => e.CategoryId)
                //.WithMany(c => c.Products)
                //.HasForeignKey(e => e.CategoryId)
                //.OnDelete(DeleteBehavior.Cascade);
            });
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
