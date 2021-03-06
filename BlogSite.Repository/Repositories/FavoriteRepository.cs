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
    public class FavoriteRepository : GenericRepository<Favorite>, IFavoriteRepository
    {
        public FavoriteRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<bool> IsDeletedAsync(Favorite favorite)
        {
             var result=  await _context.Favorites
                .Select(x => x.Id == favorite.Id).FirstOrDefaultAsync();
            return result;
        }
    }
}
