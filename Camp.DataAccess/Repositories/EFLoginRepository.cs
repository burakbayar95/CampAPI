using Camp.Models;
using Movies.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Camp.DataAccess.Repositories
{
   public class EFLoginRepository : ILoginRepository
    {
        private CampsDBContext db;
        public EFLoginRepository(CampsDBContext campsDBContext)
        {
            this.db = campsDBContext;
        }

        public Login Add(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public IList<Login> GetAll()
        {
            return db.Logins.ToList();
        }

        public Login GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Login> GetWithCriteria(Expression<Func<Login, bool>> criteria)
        {
            throw new NotImplementedException();
        }
    }
}
