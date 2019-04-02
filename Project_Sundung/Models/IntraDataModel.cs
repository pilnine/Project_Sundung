using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Project_Sundung.Models
{
    public class IntraDataModel
    {
        [Required, Key]
        [Display(Name = "Date")]
        public DateTime Time { get; set; }

        [Required]
        [Display(Name = "Value")]
        public string Value { get; set; }
    }
}