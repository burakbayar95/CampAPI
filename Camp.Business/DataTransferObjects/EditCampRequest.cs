using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Camp.Business.DataTransferObjects
{
   public class EditCampRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage="Boş olamaz")]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int GenreId { get; set; }
        public string City { get; set; }
    }
}
