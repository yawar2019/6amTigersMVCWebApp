using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _6amTigersMVCWebApp.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage ="UserName is Required")]
        public string UserName { get; set; }
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Miss Match of password and confirm password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Range(18,40,ErrorMessage ="age should be between 18-40")]
       public int age { get; set; }

        [DataType(DataType.EmailAddress,ErrorMessage ="EmailId is invalid")]
        public string EmailId { get; set; }
        [StringLength(10,ErrorMessage ="More then 10 not allowed")]
        public string Address { get; set; }

    }
}