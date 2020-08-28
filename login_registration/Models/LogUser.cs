using System;

using System.ComponentModel.DataAnnotations;

namespace login_registration
{


    public class LogUser
    {
        [Required]
        [EmailAddress]
        public string email {get; set;}

        [Required]
        [DataType(DataType.Password)]
        public string pswd {get; set;}


        // public LogUser(){
        //     email = "testing@test.com";
        //     pswd  = "12345";
        // }

    }
}