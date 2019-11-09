using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamsPractice.Models
{
    public class Team
    {
        [Required(ErrorMessage = "This field is required")]
        [StringLength(5, MinimumLength = 2, ErrorMessage ="Must be between 2 and 5 characters")]
        [Display(Name = "Team Code")]
        public string Team_Code { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Team Name")]
        public string Team_Name { get; set; }
    }
}