using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarProj.Models
{
    public class ContactModels
    {
       
        public ContactModels()
        {
            email = null;
            name = null;
            message = null;
            subject = null;

        }
        [Required]
        public string email { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string message { get; set; }

        public string subject { get; set; }
    }
}