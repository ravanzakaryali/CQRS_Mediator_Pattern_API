using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persistence.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.IsDeleted).HasDefaultValue(false);
            builder.Property(u => u.RegisterDate).HasDefaultValueSql("GETUTCDATE()");
            builder.Property(u=>u.Firstname).HasMaxLength(50);
            builder.Property(u=>u.Lastname).HasMaxLength(50);
        }
    }
}
