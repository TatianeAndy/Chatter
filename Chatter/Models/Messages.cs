using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chatter.Models
{
    public class Messages
    {
        [Key]
        public int MessageID { get; set; }
        public string MessageContent { get; set; }
        public string UserEmail { get; set; }
        
        public virtual ApplicationUser ApplicationUser { get; set; }


    }
}