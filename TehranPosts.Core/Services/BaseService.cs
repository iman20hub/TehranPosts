
using TehranPosts.Domain.Models;
using TehranPosts.Domain.InterfaceRepositories;
using System.Collections.Generic;
using TehranPosts.Core.InterfaceServices;
using System.Linq;

namespace TehranPosts.Core.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        protected readonly IBaseRepository<TEntity> _entityRepository;

        public BaseService(IBaseRepository<TEntity> entityRepository)
        {
            _entityRepository = entityRepository;
        }


        public void Create(TEntity entity)
        {
            _entityRepository.Insert(entity);
        }

        public void Delete(int entityId)
        {
            _entityRepository.DeleteById(entityId);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _entityRepository.GetAll();
        }

        public TEntity GetById(int entityId)
        {
            return _entityRepository.GetById(entityId);
        }

        public void Update(TEntity entity)
        {
            _entityRepository.Update(entity);
        }
    }
}