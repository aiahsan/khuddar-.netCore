using KhuddarVsModals.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KhuddarVSDatabase
{
    public class Repository<TEntity> : IRepositoryInterface<TEntity> where TEntity : class
    {

        protected readonly KhuddarContext _Context;

        public Repository(KhuddarContext Contex)
        {
            _Context = Contex;
        }

        public void Add(TEntity entity)
        {
            _Context.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _Context.Set<TEntity>().AddRange(entities);
        }

        public async Task<IEnumerable<TEntity>> asyncFind(Expression<Func<TEntity, bool>> Predicate)
        {
            return await _Context.Set<TEntity>().Where(Predicate).ToListAsync();
        }

        public async Task<TEntity> asyncFirstOrDefault(Expression<Func<TEntity, bool>> Predicate)
        {
            return await _Context.Set<TEntity>().FirstOrDefaultAsync(Predicate);
        }

        public async Task<TEntity> asyncGet(int Id)
        {
            return await _Context.Set<TEntity>().FindAsync(Id);
        }

        public async Task<IEnumerable<TEntity>> asyncGetAll()
        {
            return await _Context.Set<TEntity>().ToListAsync();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> Predicate)
        {
            return _Context.Set<TEntity>().Where(Predicate).ToList();
        }

        public TEntity FirstOrDefault(Expression<Func<TEntity, bool>> Predicate)
        {
            return _Context.Set<TEntity>().FirstOrDefault(Predicate);
        }

        public TEntity Get(int Id)
        {
            return _Context.Set<TEntity>().Find(Id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _Context.Set<TEntity>().ToList();
        }

        public void remove(TEntity entity)
        {
            _Context.Set<TEntity>().Remove(entity);
        }

        public void removeRange(IEnumerable<TEntity> entities)
        {
            _Context.Set<TEntity>().RemoveRange(entities);
        }
    }
}
