using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TehranPosts.Domain.InterfaceRepositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(int Id);
        void Insert(TEntity entityObj);
        void Update(TEntity entityObj);
        void DeleteById(int Id);

    }
}