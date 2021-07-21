
using Camp.Models;
using Microsoft.EntityFrameworkCore;
using Movies.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Camp.DataAccess.Repositories
{
    public class EFCampRepository  : ICampResponsitory// => niye hata verdiğini çöz
    {
        private CampsDBContext db;

        public EFCampRepository(CampsDBContext campsDBContext)
        {
            db = campsDBContext;
        }
        //public Models.Camp Add(Models.Camp entity)
        //{
        //    db.Camps.Add(entity);
        //    db.SaveChanges();
        //    return entity; //interface de sorun çıktı. burası düzenlendi 
        //    // TO DO: Tekrardan bakılacak
        //}

        public Models.Camp Add(IEntity entity)
        {
            throw new NotImplementedException();
        }

        public Models.Camp AddCampss(Models.Camp entity)
        {
            db.Camps.Add(entity);
            db.SaveChanges();
            return entity; //interface de sorun çıktı. burası düzenlendi 
            // TO DO: Tekrardan bakılacak
        }

        public void Delete(int id)
        {
            db.Camps.Remove(GetById(id));
            db.SaveChanges();
        }

        public IList<Models.Camp> GetAll()
        {
            return db.Camps.ToList();
        }

        public Models.Camp GetById(int id)
        {
            return db.Camps.AsNoTracking().FirstOrDefault(x => x.Id == id); //?
        }

        public IList<Models.Camp> GetWithCriteria(Expression<Func<Models.Camp, bool>> criteria)
        {
            throw new NotImplementedException();
        }

        public Models.Camp Update(Models.Camp camp)
        {
            db.Entry(camp).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
            return camp;
        }
    }
}
