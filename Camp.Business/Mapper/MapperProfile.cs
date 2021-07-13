using AutoMapper;
using Camp.Business.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Camp.Business.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Camp.Models.Camp, CampListResponse>().ReverseMap();
            CreateMap<Camp.Models.Camp, AddNewCampRequest>().ReverseMap();
        }
    }
}
