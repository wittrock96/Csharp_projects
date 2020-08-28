using System;

using System.ComponentModel.DataAnnotations;

namespace testing_mvc.Models
{


    public class User
    {

        [Required]
        [MinLength(3)]
        [NoZNames]
        public string firstName { get; set; }

        [Required]
        [MinLength(3)]
        public string lastName { get; set; }

        [Required]
        public int age {get; set; }


        [EmailAddress]
        public string EmailAddress { get; set; }

        [FutureDate]
        public string startDay { get; set; }

        [DataType(DataType.Password)]
        [MinLength(5)]
        public string pswd { get; set; }




    }

    public class NoZNamesAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if(((string)value).ToLower() [0] == 'z')
                return new ValidationResult("no names that start with Z allowed!");
            return ValidationResult.Success;
        }
    }
    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {

            string strvalue = value.ToString();
            var datetime = DateTime.Parse(strvalue);
            if (datetime < DateTime.Now)
            {
                return new ValidationResult("date cannot be before the current date");
            }
            else
            {
                
                return ValidationResult.Success;
            }
            // Console.WriteLine(value.ToString());


            // if()
        }
    }
    // public abstract class ValidationAttribute : Attribute
    // {

    // }
}