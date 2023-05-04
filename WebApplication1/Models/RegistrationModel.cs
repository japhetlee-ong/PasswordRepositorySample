using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class RegistrationModel
    {
        public string USERNAME { get;set; }
        public string PASSWORD { get;set; }
        public string NAME { get;set; }
        public string EMAIL { get;set; }
        public string REPEAT_PASSWORD { get;set; }
    }
}