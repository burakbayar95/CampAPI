using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Camp.Models
{
    public class Camp : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Kamp adı boş olamaz")]

        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int GenreId { get; set; }


        //Navigation Property
        public virtual Genre Genre { get; set; }


    }
}
