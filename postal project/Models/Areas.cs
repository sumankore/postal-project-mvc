using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace postal_project.Models
{
    public class Areas
    {
       [ Key]
        public int AreaID { get; set; }

        [Required(ErrorMessage = "Enter area Name")]
        [MinLength(3, ErrorMessage = "minimum 3 characters are allowed")]
        public string Name { get; set; }
        [Range(0, Int64.MaxValue, ErrorMessage = "pincode should not contain characters")]
        //[StringLength(6, MinimumLength = 1, ErrorMessage = "pincode number should have minimum 11 digits")]
        public int pincode { get; set; }
        public int CityID { get; set; }
        public bool isactive { get; set; }
    }
}