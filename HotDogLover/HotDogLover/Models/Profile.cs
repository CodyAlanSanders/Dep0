using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotDogLover.Models
{
    public class Profile
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "A first name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "A last name is required")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string Bio { get; set; }

        public string ImageUrl { get; set; }

        [Display(Name = "Favorite Dog")]
        public string FavoriteDog { get; set; }

        [Display(Name = "Location Last Eaten")]
        public string LastAte { get; set; }

        [Display(Name = "Date Last Eaten")]
        [DataType(DataType.Date)]
        public DateTime DateEaten { get; set; }

        [Display(Name = "Rating (1-5)")]
        [Range(1, 5)]
        public int Rating { get; set; }
    }
}