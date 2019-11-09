using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TeamsPractice.Models
{
    public class Player
    {
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Player Code")]
        public int Player_Code { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Player First Name")]
        public string Player_First_Name { get; set; }
        
        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Player Last Name")]
        public string Player_Last_Name { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Position")]
        public string Position_Code { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [Display(Name = "Team")]
        public string Team_Code { get; set; }
    }
}