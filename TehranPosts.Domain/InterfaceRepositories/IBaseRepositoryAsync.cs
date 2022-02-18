using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace TehranPosts.Domain.InterfaceRepositories
{
    public interface IBaseRepositoryAsync<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAllAsListAsync();
        Task<TEntity> GetByIdAsync(int Id);
        void InsertRange(List<TEntity> entitylist);
        Task InsertAsync(TEntity entityObj);
        Task DeleteByIdAsync(int Id);
        //Task SaveChangesAsync(int Id);
    }
}