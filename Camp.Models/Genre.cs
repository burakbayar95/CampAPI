using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Camp.Models
{
    public class Genre : IEntity
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        public int Name { get; set; }

        public virtual IList<Camp> Camps { get; set; }


    }
}
