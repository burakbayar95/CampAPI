using Camp.Models;
using Movies.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Camp.DataAccess.Repositories
{
    public class EFGenreRepository : IGenreRepository
    {
        private CampsDBContext db;

        public EFGenreRepository(CampsDBContext campsDBContext)
        {
            db = campsDBContext;
        }
        public Genre Add(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public IList<Genre> GetAll()
        {
            return db.Genres.ToList();
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
