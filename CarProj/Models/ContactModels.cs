using System;
using System.Collections.Generic;
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
        public string email { get; set; }
        public string name { get; set; }
        public string message { get; set; }

        public string subject { get; set; }
    }
}