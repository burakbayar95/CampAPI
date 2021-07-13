using Camp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Movies.DataAccess.Data;

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

        public Genre AddCampss(Models.Camp camp)
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
