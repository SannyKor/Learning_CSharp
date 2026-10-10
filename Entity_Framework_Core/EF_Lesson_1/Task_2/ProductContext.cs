using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Task_2.Configurations;
using Task_2.Models;

namespace Task_2
{
    public class ProductContext : DbContext
    {
        public ProductContext()
        {
            //Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<Cart> Carts { get; set; } = null!;
        public DbSet<Word> Words { get; set; } = null!;
        public DbSet<KeyParams> KeyParams { get; set; } = null!;
        public List<Error> Errors { get; set; } = new List<Error>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ProductDB;Trusted_Connection=true;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CartConfiguration());
            modelBuilder.ApplyConfiguration(new WordConfiguration());
            modelBuilder.ApplyConfiguration(new KeyParamsConfiguration());

            modelBuilder.Ignore<Error>();


        }
    }
}
