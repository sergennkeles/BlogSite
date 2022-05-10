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
    public class FacebookConfiguration : IEntityTypeConfiguration<Facebook>
    {
        public void Configure(EntityTypeBuilder<Facebook> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.FacebookUrl).HasMaxLength(300);
            builder.HasOne(p => p.User).WithOne(a => a.Facebook).HasForeignKey<Facebook>(p => p.UserId);
            builder.ToTable("Facebooks");
        }
    }
}
