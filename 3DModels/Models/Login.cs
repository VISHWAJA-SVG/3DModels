using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _3DModels.Models
{
    public class Login
    {
        public string Role { get; set; }
        
        public string EmailID { get; set; }

           public string Password { get; set; }

    }
}
