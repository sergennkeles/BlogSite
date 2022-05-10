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
    public class TwitterService : Service<Twitter>, ITwitterService
    {
        public TwitterService(IUnitOfWork unitOfWork, IGenericRepository<Twitter> genericRepository) : base(unitOfWork, genericRepository)
        {
        }
    }
}
