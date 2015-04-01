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
        public Hotdogs FavoriteDog { get; set; }

        public List<Hotdogs> HotdogList { get; set; }
    }
}