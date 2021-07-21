using Camp.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Camp.DataAccess.Repositories
{
    public interface IRepository <TEntity> where TEntity : IEntity, new()
    {
        IList<TEntity> GetAll();
        TEntity GetById(int id);
        IList<TEntity> GetWithCriteria(Expression<Func<TEntity, bool>> criteria);
        TEntity Add(IEntity entity);

        TEntity AddCampss(Camp.Models.Camp camp);
        TEntity Update(Camp.Models.Camp camp);
        void Delete(int id);
    }
}
