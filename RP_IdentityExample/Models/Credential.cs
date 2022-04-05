using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RP_IdentityExample.Models
{
    public class Credential
    {
        [Required]
        [Display(Name ="User Name")]
             public string Username { get; set; }   

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public Credential()
        {  }
        public Credential(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
