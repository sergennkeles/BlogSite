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
    public class UserService : Service<User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUnitOfWork unitOfWork, IGenericRepository<User> genericRepository, IUserRepository userRepository) : base(unitOfWork, genericRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<User> GetUsersInfoDtoService()
        {
            return _userRepository.GetUsersInfoDto();
        }
    }
}
