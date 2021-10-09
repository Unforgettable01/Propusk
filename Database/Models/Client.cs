using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Database.Models
{
    public class Client
    {
        public int id { get; set; }
        [Required]
        public string ClientFIO { get; set; } 
    }
}
