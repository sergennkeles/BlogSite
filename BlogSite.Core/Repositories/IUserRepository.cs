using BlogSite.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Core.Repositories
{
    public  interface IUserRepository:IGenericRepository<User>
    {
        IQueryable<User> GetUsersInfoDto();
    }
}
