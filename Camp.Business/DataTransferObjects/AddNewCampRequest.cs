using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Camp.Business.DataTransferObjects
{
    public class AddNewCampRequest
    {
        [Required(ErrorMessage ="Ad belirtmediniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Fiyat belirtmediniz")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Açıklama belirtmediniz")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Resim url belirtmediniz")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Tür belirtmediniz")]
        public int GenreId { get; set; }

        [Required(ErrorMessage = "Şehir belirtmediniz")]
        public string City { get; set; }

    }
}
