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
    public class InstagramRepository : GenericRepository<Instagram>, IInstagramRepository
    {
        public InstagramRepository(AppDbContext context, DbSet<Instagram> dbSet) : base(context, dbSet)
        {
        }
    }
}
