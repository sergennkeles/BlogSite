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
    public class TwitterConfiguration : IEntityTypeConfiguration<Twitter>
    {
        public void Configure(EntityTypeBuilder<Twitter> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.TwitterUrl).HasMaxLength(300);
            builder.HasOne(p => p.User).WithOne(a => a.Twitter).HasForeignKey<Twitter>(p => p.UserId);
            builder.ToTable("Twitters");
        }
    }
}
