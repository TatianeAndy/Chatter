using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Chatter.Models
{
    public class Procedure
    {
        [Key]
        public int ID { get; set; }
        public string Email { get; set; }

    }
}