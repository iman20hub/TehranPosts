
using TehranPosts.Domain.Models;
using System.Collections.Generic;
namespace TehranPosts.Core.InterfaceServices
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        void Update(TEntity entity);
        void Delete(int entityId);
        TEntity GetById(int entityId);
        IEnumerable<TEntity> GetAll();
    }
}