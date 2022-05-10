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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.FirstName).HasMaxLength(50).IsRequired().HasColumnType("nvarchar");
            builder.Property(x => x.LastName).HasMaxLength(50).IsRequired().HasColumnType("nvarchar");
            builder.Property(x => x.Email).HasMaxLength(50).IsRequired().HasColumnType("nvarchar");
            builder.Property(x => x.Password).HasMaxLength(50).IsRequired().HasColumnType("nvarchar");

            builder.ToTable("Users");

        }
    }
}
