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
    public class PostSeed : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasData(new Post
            {
                Id = 1,
                UserId = 1,
                Title = "Post 1",
                Content = "Content 1",

            },
            new Post
            {
                Id = 2,
                UserId = 1,
                Title = "Post 2",
                Content = "Content 2",

            }) ;
         }
    }
}
