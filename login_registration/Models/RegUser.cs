using System;

using System.ComponentModel.DataAnnotations;

namespace login_registration
{


    public class RegUser
    {
        [Required]
        [MinLength(2)]
        public string first_name {get; set;}
        [Required]
        [MinLength(2)]
        public string last_name {get; set;}
        [Required]
        [EmailAddress]
        public string email {get; set;}
        [DataType(DataType.Password)]
        [MinLength(5)]
        public string pswd {get; set;}







    }
}