using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Configuration
{
    public class BlogConfiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(u=>u.IsModified).HasDefaultValue(false);
            builder.Property(u=>u.IsDeleted).HasDefaultValue(false);
            builder.Property(u=>u.IsArchive).HasDefaultValue(false);
            builder.Property(u=>u.CreatedDate).HasDefaultValueSql("GETUTCDATE()");
            builder.Property(u=>u.Content).IsRequired();
            builder.Property(u=>u.Title).HasMaxLength(150).IsRequired();
        }
    }
}
