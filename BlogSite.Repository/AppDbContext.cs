using BlogSite.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Repository
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Github> Githubs { get; set; }
        public DbSet<Twitter> Twitters { get; set; }
        public DbSet<Facebook> Facebooks { get; set; }
        public DbSet<Instagram> Instagrams { get; set; }
        public DbSet<Favorite> Favorites { get; set; }

    }
}
