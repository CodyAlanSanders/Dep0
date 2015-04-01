using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace HotDogLover.Models
{
    public class Hotdogs
    {
        [Display(Name = "Hotdog Number")]
        public int Id { get; set; }

        [Required(ErrorMessage = "A name is required")]
        public string Name { get; set; }

        [Display(Name = "Location Last Eaten")]
        public string LastAte { get; set; }

        [Display(Name = "Date Last Eaten")]
        public DateTime LastEaten { get; set; }

        [Display(Name = "Rating")]
        [Required(ErrorMessage = "A rating (1-5) is required.")]
        [Range(1, 5)]
        public int Rating { get; set; }
    }
}
