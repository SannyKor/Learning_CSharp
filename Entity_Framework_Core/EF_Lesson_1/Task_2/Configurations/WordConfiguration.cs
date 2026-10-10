using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Task_2.Models;

namespace Task_2.Configurations
{
    public class WordConfiguration : IEntityTypeConfiguration<Word>
    {
        public void Configure(EntityTypeBuilder<Word> builder)
        {
            builder.ToTable("Words");

            builder.Property(w => w.Header)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasKey(w => w.Id);

            builder.Property(w => w.KeyWord)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasIndex(w => w.KeyWord)
                .IsUnique();

        }
    }
}
