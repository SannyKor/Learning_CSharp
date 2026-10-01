using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Task_2.Models;

namespace Task_2.Configurations
{
    public class KeyParamsConfiguration : IEntityTypeConfiguration<KeyParams>
    {
        public void Configure(EntityTypeBuilder<KeyParams> builder)
        {
            builder.ToTable("KeyParams");

            builder.HasKey(k => k.Id);

            builder.HasIndex(kp => new { kp.ProductId, kp.WordId })
                .IsUnique();

            builder.HasOne(kp => kp.Product)
                .WithMany(p => p.Keywords)
                .HasForeignKey(kp => kp.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(kp => kp.Keywords)
                .WithMany(w => w.ProductLink)
                .HasForeignKey(kp => kp.WordId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
