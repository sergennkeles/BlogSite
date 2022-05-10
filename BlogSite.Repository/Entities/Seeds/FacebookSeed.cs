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
    public class FacebookSeed : IEntityTypeConfiguration<Facebook>
    {
        public void Configure(EntityTypeBuilder<Facebook> builder)
        {
            builder.HasData(new Facebook { 
                Id = 1,
                UserId=1,
                FacebookUrl = "https://www.facebook.com/" 
            });
        }
    }
}
