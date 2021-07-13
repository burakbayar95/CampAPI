using AutoMapper;
using Camp.Business.DataTransferObjects;
using Camp.Models;
using Movies.Business.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camp.Business.Extensions
{
   public static class Converters
    {
        public static List<GenreListResponse> ConvertToListResponse(this List<Genre> genres)
        {
            var result = new List<GenreListResponse>();
            genres.ForEach(x => result.Add(new GenreListResponse
            {

                Id = x.Id,
                Name = x.Name

            }));
            return result;
        }

        public static List<CampListResponse>ConvertToListResponse(this List<Camp.Models.Camp> camps ,IMapper mapper)

        {
            return mapper.Map<List<CampListResponse>>(camps);
        }

        public static Camp.Models.Camp ConvertToCamp(this AddNewCampRequest request,IMapper mapper)
        {
            return mapper.Map<Camp.Models.Camp>(request);
        }
    }
}
