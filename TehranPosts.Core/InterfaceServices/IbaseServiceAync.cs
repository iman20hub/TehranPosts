
using TehranPosts.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TehranPosts.Core.InterfaceServices
{
    public interface IBaseServiceAsync<TEntity> where TEntity : class
    {
        Task Create(TEntity entity);
        //Task Update(TEntity entity);
        Task Delete(int entityId);
        Task<TEntity> GetById(int entityId);
        Task<IEnumerable<TEntity>> GetAll();
    }
}