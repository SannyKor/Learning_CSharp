using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Task_1;

namespace Task_2
{
    public class ProductContext : DbContext
    {
        public ProductContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Product> Products { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ProductDB;Trusted_Connection=true;TrustServerCertificate=True;");
        }
    }
}
