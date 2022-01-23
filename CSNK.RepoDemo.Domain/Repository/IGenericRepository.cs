using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CSNK.RepoDemo.Domain.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Get(int id);

        Task<TEntity> Get(int id, string includeProperties = "");

        Task<IEnumerable<TEntity>> GetAll();

        Task<IEnumerable<TEntity>> GetAll(Expression<Func<TEntity, bool>>? filter = null,
                                       Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>>? orderBy = null,
                                       string includeProperties = "");

        Task Add(TEntity entity);

        void Delete(TEntity entity);
        
        void Update(TEntity entity);
    }
}
