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
    public class FacebookService : Service<Facebook>, IFacebookService
    {
        public FacebookService(IUnitOfWork unitOfWork, IGenericRepository<Facebook> genericRepository) : base(unitOfWork, genericRepository)
        {
        }
    }
}
