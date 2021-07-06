using Camp.Models;
using Movies.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Camp.DataAccess.Repositories
{
   public class EFCampRepository : ICampResponsitory
    {
        private CampsDBContext db;

        public EFCampRepository(CampsDBContext campsDBContext)
        {
            db = campsDBContext;
        }
        public Models.Camp Add(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public IList<Models.Camp> GetAll()
        {
            return db.Camps.ToList();
        }

        public Models.Camp GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Models.Camp> GetWithCriteria(Expression<Func<Models.Camp, bool>> criteria)
        {
            throw new NotImplementedException();
        }
    }
}
