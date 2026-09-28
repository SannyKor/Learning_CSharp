using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Task_2
{
    public class ProductContext : DbContext
    {
        public ProductContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Product> Products { get; set; } = null!;
        public List<Error> Errors { get; set; } = new List<Error>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ProductDB;Trusted_Connection=true;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Products");

                entity.HasKey(p => new { p.ProductId, p.ProductAlterId });

                entity.Property(p => p.Name)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(p => p.Cost)
                      .HasColumnType("Money")
                      .IsRequired();

                entity.Property(p => p.Description)
                      .HasMaxLength(250)
                      .IsRequired();

                entity.Property(p => p.Quantity)
                      .IsRequired();
            });
            modelBuilder.Ignore<Error>();
        }
    }
}
