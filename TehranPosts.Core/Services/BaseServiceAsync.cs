
using TehranPosts.Domain.Models;
using TehranPosts.Domain.InterfaceRepositories;
using System.Collections.Generic;
using TehranPosts.Core.InterfaceServices;
using System.Linq;
using System.Threading.Tasks;

namespace TehranPosts.Core.Services
{
    public class BaseServiceAsync<TEntity> : IBaseServiceAsync<TEntity> where TEntity : class
    {
        protected readonly IBaseRepositoryAsync<TEntity> _entityRepository;

        public BaseServiceAsync(IBaseRepositoryAsync<TEntity> entityRepository)
        {
            _entityRepository = entityRepository;
        }

        public async Task Create(TEntity entity)
        {
            await _entityRepository.InsertAsync(entity);
        }

        public async Task Delete(int entityId)
        {
            await _entityRepository.DeleteByIdAsync(entityId);
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await _entityRepository.GetAllAsListAsync();
        }

        public async Task<TEntity> GetById(int entityId)
        {
            return await _entityRepository.GetByIdAsync(entityId);
        }

        // public Task Update(TEntity entity)
        // {
        //     throw new System.NotImplementedException();
        // }
    }
}