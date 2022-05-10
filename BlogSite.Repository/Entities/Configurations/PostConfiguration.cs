using BlogSite.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Repository.Entities.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.Title).IsRequired().HasMaxLength(300);
            builder.Property(p => p.Content).IsRequired();
            builder.HasOne(p => p.User).WithMany(a =>a.Posts).HasForeignKey(p => p.UserId);
            builder.ToTable("Posts");

        }
    }
}
