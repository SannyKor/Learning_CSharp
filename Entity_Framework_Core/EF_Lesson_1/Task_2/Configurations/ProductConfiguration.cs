using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task_2.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");

            builder.HasKey(p => new { p.ProductId, p.ProductAlterId });

            builder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.Cost)
                .HasColumnType("Money")
                .IsRequired();

            builder.Property(p => p.ActionCost)
                .HasColumnType("Money")
                .IsRequired();

            builder.Property(p => p.Description)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(p => p.DescriptionField1)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(p => p.DescriptionField2)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(p => p.Quantity)
                .IsRequired();

            builder.HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
