

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TehranPosts.Domain.Models;

namespace TehranPosts.Data.EntityTypeConfigurations
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(t => t.LastName).HasColumnName("LName");
            builder.Property(t => t.LastName).IsRequired().HasMaxLength(20);
            builder.Property(t => t.FirstName).HasColumnName("FName");
            builder.Property(t => t.birthDate).IsRequired();
            // builder.HasOne(d => d.blog).WithOne(p => p.User).IsRequired(false);
        }
    }
}
