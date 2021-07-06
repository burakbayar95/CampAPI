using System;
using System.Collections.Generic;
using System.Text;

namespace Camp.Models
{
    public class Login  :IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        
        

    }
}
