﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class UserDTO
    {
       
        public string Username { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
  
        public string Gender { get; set; }
      
        public DateTime Dob { get; set; }
       
        public string Email { get; set; }
        
        public string Phone { get; set; }
        public string Address { get; set; }

        public string Type { get; set; }
    }
}
