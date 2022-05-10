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
    public class FavoriteConfiguration : IEntityTypeConfiguration<Favorite>
    {
        public void Configure(EntityTypeBuilder<Favorite> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.Property(p => p.IsDeleted).HasDefaultValue(false);
            builder.HasOne(p => p.User).WithMany(a => a.Favorites).HasForeignKey(p => p.UserId).HasConstraintName("users_favorites_fk").OnDelete(DeleteBehavior.Restrict);
          //  builder.HasOne(p => p.Post).WithMany(a => a.Favorites).HasForeignKey(p => p.PostId).HasConstraintName("posts_favorites_fk");

            builder.ToTable("Favorites");
        }
    }
}
