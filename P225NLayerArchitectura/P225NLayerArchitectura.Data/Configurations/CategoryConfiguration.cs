using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using P225NLayerArchitectura.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace P225NLayerArchitectura.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(b => b.Name).HasMaxLength(25).IsRequired(true);
            builder.Property(b => b.Image).HasMaxLength(255).IsRequired(false);
        }
    }
}
