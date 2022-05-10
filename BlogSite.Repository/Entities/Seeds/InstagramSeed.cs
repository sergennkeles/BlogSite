using BlogSite.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Repository.Entities.Seeds
{
    public class InstagramSeed : IEntityTypeConfiguration<Instagram>
    {
        public void Configure(EntityTypeBuilder<Instagram> builder)
        {
            builder.HasData(new Instagram
            {
                Id = 1,
                UserId=1,
                InstagramUrl = "https://www.instagram.com/"
            });
        }
    }
}
