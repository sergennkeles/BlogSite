using BlogSite.Core.Entities;
using BlogSite.Core.Repositories;
using BlogSite.Core.Services;
using BlogSite.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BlogSite.Service.Repositories
{
    public class Service<T> : IService<T> where T : BaseEntity
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenericRepository<T> _genericRepository;

        public Service(IUnitOfWork unitOfWork,IGenericRepository<T> genericRepository)
        {
            _unitOfWork = unitOfWork;
            _genericRepository = genericRepository;
        }

        public async Task AddAsync(T entity)
        {
            await _genericRepository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
     
        }

        public void Delete(T entity)
        {
            _genericRepository.Delete(entity);
            _unitOfWork.Commit();
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return _genericRepository.FindBy(predicate);
            
        }

        public IQueryable<T> GetAll()
        {
            return _genericRepository.GetAll();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _genericRepository.GetByIdAsync(id);
        }

        public void Update(T entity)
        {
            _genericRepository.Update(entity);
            _unitOfWork.Commit();
        }
    }
}
