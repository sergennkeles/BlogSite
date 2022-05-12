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
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(AppDbContext context) : base(context)
        {
        }

        public IQueryable<User> GetUsersInfoDto()
        {
          return  _context.Set<User>()
                .Include(x => x.Twitter)
                .Include(x => x.Facebook)
                .Include(x => x.Posts)
                .Include(x => x.Comments)
                .Include(x => x.Favorites)
                .Include(x => x.Github)
                .Include(x => x.Instagram)
                .AsNoTracking().AsQueryable();
            
        }
    }
}
