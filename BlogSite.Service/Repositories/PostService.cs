
using BlogSite.Core.Entities;
using BlogSite.Core.Repositories;
using BlogSite.Core.Services;
using BlogSite.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Service.Repositories
{
    public class PostService : Service<Post>, IPostService
    {
        public PostService(IUnitOfWork unitOfWork, IGenericRepository<Post> genericRepository) : base(unitOfWork, genericRepository)
        {
        }
    }
}
