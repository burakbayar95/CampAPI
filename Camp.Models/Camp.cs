using System;
using System.Collections.Generic;
using System.Text;

namespace Camp.Models
{
    public class Camp : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        //Navigation Property
        public virtual Genre Genre { get; set; }


    }
}
