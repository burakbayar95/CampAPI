using Camp.API.Filters;
using Camp.Business;
using Camp.Business.DataTransferObjects;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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

        [HttpGet]
        public IActionResult Get()
        {
            var result = service.GetAllCamps();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = service.GetAllCamps();

            List<CampListResponse> list = new List<CampListResponse>();

            foreach (var item in result)
            {
                if (item.Id == id)
                {
                    list.Add(item);
                }
            }

            if (list == null || list.Count == 0)
            {
                return NotFound();
            }
            return Ok(list);
        }

        [HttpGet("genres/{GenreId}")]
        public List<CampListResponse> GetCampsByGenre(int GenreId)
        {
            var result = service.GetAllCamps();
            List<CampListResponse> list = new List<CampListResponse>();

            foreach (var item in result)
            {
                if (item.GenreId == GenreId)
                {
                    list.Add(item);
                }
            }
            if (list == null || list.Count == 0)
            {
             //   return NotFound();
            }
            return list;
        }
        [HttpGet("genre/{GenreId}/{city}")]
        public IActionResult GetCampsByCityAndGenres(int GenreId,string city)
        {
            var result = service.GetAllCamps();
            List<CampListResponse> list = new List<CampListResponse>();
           //var result2 = GetCampsByGenre(GenreId);
            foreach (var item in result)//result2
            {
                if (item.GenreId==GenreId && item.City == city)
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
            

        //*********************


        [HttpGet("city/{City}")]
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

            if (list == null || list.Count == 0)
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
       
        [HttpPost]
        public IActionResult AddCamp(AddNewCampRequest request)
        {
            if (ModelState.IsValid)
            {
                int requestid=service.AddCamp(request);
                return CreatedAtAction(nameof(GetById), routeValues: new { id = requestid }, value: null);//ekledikten sonra bize linkini verir
            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        [CampExist]
        public IActionResult UpdateCamp(int id,EditCampRequest request)
        {
            //var isExisting = GetById(id);      [CampExist] bu işlemi yapu
            //if (isExisting==null)
            //{
            //    return NotFound();
            //} asnotracking eklememiz gerek 
            if (ModelState.IsValid)
            {
              int newItemId = service.UpdateCamp(request);
                return Ok(newItemId);

            }
            return BadRequest(ModelState);

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            service.DeleteCamp(id);

            
            return Ok();
        }

    }
}

