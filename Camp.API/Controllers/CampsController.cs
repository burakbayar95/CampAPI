using Camp.Business;
using Camp.Business.DataTransferObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Camp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampsController : ControllerBase
    {
        private ICampService service;
        public CampsController(ICampService service)
        {
            this.service = service;
        }

        public IActionResult Get()
        {
            var result = service.GetAllCamps();
            return Ok(result);
        }

        [HttpGet("{GenreId}")]
        

        public IActionResult GetCampsByGenre(int GenreId)
        {
            var result = service.GetAllCamps();
            List<CampListResponse> list = new List<CampListResponse>();

            foreach (var item in result)
            {
              if(item.GenreId==GenreId)
                {
                    list.Add(item);
                }
            }   
            
            //FirstOrDefault(c => c.GenreId == GenreId);
            if (list == null || list.Count == 0)
            {
                return NotFound();
            }
            return Ok(list);

        }

       [HttpGet("City/{City}")]
        //[Route("api/{City}")]
      // api/camps/city/izmir şeklinde aranır
        public IActionResult GetCampsByCity(string City)
        {

            var result = service.GetAllCamps();
            List<CampListResponse> list = new List<CampListResponse>();

            foreach (var item in result)
            {
                if (item.City == City)
                {
                    list.Add(item);
                }
            }

            
            if (list == null || list.Count==0)
            {
                return NotFound();
            }
            return Ok(list);


            //var result = service.GetAllCamps();
            //var camps = result.FirstOrDefault(c => c.City == City);

            //if (camps == null)
            //{
            //    return NotFound();
            //}
            //return Ok(camps);

        }
    }
}
