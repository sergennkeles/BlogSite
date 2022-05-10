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
    public class TwitterSeed : IEntityTypeConfiguration<Twitter>
    {
        public void Configure(EntityTypeBuilder<Twitter> builder)
        {
            builder.HasData(new Twitter {
                Id = 1,
                UserId = 1,
                TwitterUrl = "https://twitter.com/BlogSite" }
                ) ;
        }
    }
}
