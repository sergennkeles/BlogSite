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
    public class GithubSeed : IEntityTypeConfiguration<Github>
    {
        public void Configure(EntityTypeBuilder<Github> builder)
        {
            builder.HasData(new Github
            {
                Id = 1,
                UserId=1,
                GithubUrl = "https://www.github.com/ "
            });
        }
    }
}
