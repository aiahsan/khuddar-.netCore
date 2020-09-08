using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KhuddarVsModals.Interfaces
{
    public interface IRepositoryInterface<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> Predicate);
        Task<IEnumerable<TEntity>> asyncFind(Expression<Func<TEntity, bool>> Predicate);
        TEntity Get(int Id);
        Task<TEntity> asyncGet(int Id);
        IEnumerable<TEntity> GetAll();
        Task<IEnumerable<TEntity>> asyncGetAll();
        TEntity FirstOrDefault(Expression<Func<TEntity, bool>> Predicate);
        Task<TEntity> asyncFirstOrDefault(Expression<Func<TEntity, bool>> Predicate);
        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);
        void remove(TEntity entity);
        void removeRange(IEnumerable<TEntity> entities);
    }
    
}
