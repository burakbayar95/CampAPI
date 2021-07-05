using Camp.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Camp.DataAccess.Repositories
{
    public class EFGenreRepository : IGenreRepository
    {
        public Genre Add(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public IList<Genre> GetAll()
        {
            throw new NotImplementedException();
        }

        public Genre GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Genre> GetWithCriteria(Expression<Func<Genre, bool>> criteria)
        {
            throw new NotImplementedException();
        }
    }
}
