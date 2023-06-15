using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace postal_project.Models
{
    public class States
    {
        [Key]
        public int StateID { get; set; }

        [Required(ErrorMessage = "Enter state Name")]
        [MinLength(3, ErrorMessage = "State name should be minimum 3 characters")]
        public string Name { get; set; }
        public int CountryID { get; set; }
        public bool isactive { get; set; }
    }
}