using Camp.Business.DataTransferObjects;
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

        public CampService()
        {
        }

        public CampService(ICampResponsitory campResponsitory)
        {
            this.campResponsitory = campResponsitory;
        }

        public IList<CampListResponse> GetAllCamps()
        {
            var dtolist = campResponsitory.GetAll().ToList();
            List<CampListResponse> result = new List<CampListResponse>();
            dtolist.ForEach(g => result.Add(new CampListResponse
            {
                Description = g.Description,
                Image = g.Image,
                Name = g.Name,
                Price = g.Price,
                GenreId=g.GenreId
            }));
            return result;
        }

        //public IList<CampListResponse> GetByGenreId(int genreId)
        //{
        //    var dtolist = GetAllCamps().ToList();

        //    return (IList<CampListResponse>)dtolist.FirstOrDefault(id => id.GenreId == genreId);

        //}
    }
}
