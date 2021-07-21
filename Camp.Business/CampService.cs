using AutoMapper;
using Camp.Business.DataTransferObjects;
using Camp.Business.Extensions;
using Camp.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Camp.Business
{
    public class CampService : ICampService
    {
        private ICampResponsitory campResponsitory;
        private IMapper mapper;

        public CampService()
        {
        }

        public CampService(ICampResponsitory campResponsitory,IMapper mapper)
        {
            this.campResponsitory = campResponsitory;
            this.mapper = mapper;
        }

        public int AddCamp(AddNewCampRequest request)
        {
            var newCamp = request.ConvertToCamp(mapper);
            campResponsitory.AddCampss(newCamp);
            return newCamp.Id;
        }

        public IList<CampListResponse> GetAllCamps()
        {
            var dtolist = campResponsitory.GetAll().ToList();
            List<CampListResponse> result = new List<CampListResponse>();
            dtolist.ForEach(g => result.Add(new CampListResponse
            {
                 Id=g.Id,
                Description = g.Description,
                Image = g.Image,
                Name = g.Name,
                Price = g.Price,
                GenreId=g.GenreId,
                City=g.City
            }));
            return result;
        }

        public int UpdateCamp(EditCampRequest request)
        {
            var camp = request.ConverToEntity(mapper);
            int id = campResponsitory.Update(camp).Id;
            return id;
        }

        //public IList<CampListResponse> GetByCity()
        //{
        //    var dtolist = campResponsitory.GetAll().ToList();
        //    List<CampListResponse> result = new List<CampListResponse>();
        //    dtolist.ForEach(g => result.Add(new CampListResponse
        //    {
        //        Description = g.Description,
        //        Image = g.Image,
        //        Name = g.Name,
        //        Price = g.Price,
        //        GenreId = g.GenreId,
        //        City = g.City
        //    }));
        //    return result;
        //}
    }

        //public IList<CampListResponse> GetByGenreId(int genreId)
        //{
        //    var dtolist = GetAllCamps().ToList();

        //    return (IList<CampListResponse>)dtolist.FirstOrDefault(id => id.GenreId == genreId);

        //}
    
}






