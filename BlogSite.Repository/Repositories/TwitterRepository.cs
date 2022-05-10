using BlogSite.Core.Entities;
using BlogSite.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Repository.Repositories
{
    public class TwitterRepository : GenericRepository<Twitter>, ITwitterRepository
    {
        public TwitterRepository(AppDbContext context, DbSet<Twitter> dbSet) : base(context, dbSet)
        {
        }
    }
}
