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
    public class InstagramConfiguration : IEntityTypeConfiguration<Instagram>
    {
        public void Configure(EntityTypeBuilder<Instagram> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.InstagramUrl).HasMaxLength(300);
            builder.HasOne(p => p.User).WithOne(a => a.Instagram).HasForeignKey<Instagram>(p => p.UserId);
            builder.ToTable("Instagrams");
        }
    }
}
