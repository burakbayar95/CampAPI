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

        public Login AddCampss(Models.Camp camp)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
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

        public IList<Login> GetWithCriteria(Func<Login, bool> criteria)
        {
            return GetAll().Where(criteria).ToList(); //
        }

        public Login Update(Models.Camp camp)
        {
            throw new NotImplementedException();
        }
    }
}
