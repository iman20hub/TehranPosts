

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TehranPosts.Domain.Models;
//using Microsoft.
namespace TehranPosts.Data.EntityTypeConfigurations
{
    public class BlogMap : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(t => t.Title).IsRequired().HasMaxLength(20);
            builder.HasOne(p => p.User).WithOne(o => o.blog).HasForeignKey<Blog>(x => x.OwnerUserId).IsRequired(false);
        }
    }
}
