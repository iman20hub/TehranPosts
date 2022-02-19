

using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TehranPosts.Domain.Models;
//using Microsoft.
namespace TehranPosts.Data.EntityTypeConfigurations
{
    public class PostMap : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(t => t.Title).IsRequired().HasMaxLength(20);
            builder.HasOne(p => p.User).WithMany(o => o.Posts).HasForeignKey(x => x.UserId).IsRequired(false);
            builder.Property(t => t.CreateDate).IsRequired(false);

        }
    }
}
