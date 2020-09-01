using System;

using System.ComponentModel.DataAnnotations;

namespace quoting_dojo.Models
{
    public class Quote
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [MinLength(3)]
        public string saying {get; set;}

        
    }
}