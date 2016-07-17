using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BaghBaghApiTry4.Models
{
    public class BasePlant
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Catagory { get; set; }
        public string DateStamp { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string ImagePath { get; set; }
       // public int UserId { get; set; }
        //public BaseUser User { get; set; }
    }
}