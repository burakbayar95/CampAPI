using Camp.Business;
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
            var camps = result.FirstOrDefault(c => c.GenreId == GenreId);
            if (camps == null)
            {
                return NotFound();
            }
            return Ok(camps);

        }

       [HttpGet("City/{City}")]
        //[Route("api/{City}")]
      // api/camps/city/izmir şeklinde aranır
        public IActionResult GetCampsByCity(string City)
        {

            var result = service.GetAllCamps();
            var camps = result.FirstOrDefault(c => c.City == City);

            if (camps == null)
            {
                return NotFound();
            }
            return Ok(camps);

        }
    }
}
