using System.Collections.Generic;
using TehranPosts.Domain.InterfaceRepositories;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace TehranPosts.Data
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>, IBaseRepositoryAsync<TEntity> where TEntity : class
    {
        AppDbContext _dbContext;
        DbSet<TEntity> _dbSet;
        public BaseRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<TEntity>();
        }

        public void DeleteById(int Id)
        {
            TEntity obj = _dbSet.Find(Id);
        }

        public async Task DeleteByIdAsync(int Id)
        {
            TEntity obj = await _dbSet.FindAsync(Id);
            _dbSet.Remove(obj);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsListAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public TEntity GetById(int Id)
        {
            return _dbSet.Find(Id);
        }

        public async Task<TEntity> GetByIdAsync(int Id)
        {
            return await _dbSet.FindAsync(Id);
        }

        public void Insert(TEntity entityObj)
        {
            _dbSet.Add(entityObj);
        }

        public async Task InsertAsync(TEntity entityObj)
        {
            await _dbSet.AddAsync(entityObj);
        }

        public void InsertRange(List<TEntity> entitylist)
        {
            _dbSet.AddRange(entitylist);
        }

        public void Update(TEntity entityObj)
        {
            _dbSet.Update(entityObj);
        }

    }
}
