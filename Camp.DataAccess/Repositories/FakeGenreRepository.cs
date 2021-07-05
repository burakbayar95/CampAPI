using Camp.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Camp.DataAccess.Repositories
{
    class FakeGenreRepository : IGenreRepository
    {
        public Genre Add(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public IList<Genre> GetAll()
        {
            return new List<Genre>
            {
                new Genre{ Id=1, Name="Uludağ Kampı"},
                 new Genre{ Id=2, Name="Kabak Koyu Kampı"},
                 new Genre{ Id=3, Name="Akyaka Orman Kampı"}

            };
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
