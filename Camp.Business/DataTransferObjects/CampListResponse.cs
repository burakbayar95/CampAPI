using System;
using System.Collections.Generic;
using System.Text;

namespace Camp.Business.DataTransferObjects
{
    public class CampListResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int GenreId { get; set; }
        public string City { get; set; }
    }
}
