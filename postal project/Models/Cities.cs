using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace postal_project.Models
{
    public class Cities
    {
        [Key]
        public int CityID { get; set; }

        [Required(ErrorMessage = "Enter city Name")]
        [MinLength(3, ErrorMessage = "minimum 3 characters are allowed")]
        public string Name { get; set; }
        public int StateID { get; set; }
        public bool isactive { get; set; }
    }
}