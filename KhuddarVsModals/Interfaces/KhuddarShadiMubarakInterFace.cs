using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KhuddarVsModals.Interfaces
{
   public interface KhuddarShadiMubarakInterFace<TEntity> where TEntity : class
    {
        Task<TEntity> asynFirstOrdefaultWithUser(Expression<Func<TEntity, bool>> Predicate);

    }
}
