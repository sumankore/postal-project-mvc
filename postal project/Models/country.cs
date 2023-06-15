using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace postal_project.Models
{
    public class country
    {

        [Key]
        public int CountryID { get; set; }

        [Required(ErrorMessage = "Enter country Name")]
        [MaxLength(15, ErrorMessage = "maximum 15 characters are allowed")]
               public string Name { get; set; }
        public bool isactive { get; set; }
    }
}